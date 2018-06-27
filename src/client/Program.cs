using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Loader;
using System.Threading;
using Akka.Actor;
using Akka.Cluster.Sharding;
using Akka.Configuration;
using Server;
using static Client.ClientMessages.Types;

namespace Client
{
    class Program
    {
        public static ActorSystem _clusterSystem;
        static void Main(string[] args)
        {
            var hostname = Dns.GetHostName();
            Console.WriteLine($"Hostname: {hostname}");

            var hostIp = GetHostIPAddress(hostname);
            Console.WriteLine($"HostIP: {hostIp}");

            var isInDockerVal = Environment.GetEnvironmentVariable("IN_DOCKER");
            string clusterPath = hostIp;
            if (!String.IsNullOrEmpty(isInDockerVal))
            {
                clusterPath = GetHostIPAddress("server");
            }
            Console.WriteLine($"ClusterPath: {clusterPath}");

            var hcon = @"akka {
                                actor {
                                        provider = ""Akka.Cluster.ClusterActorRefProvider, Akka.Cluster"" 
                                }
                                
                                remote {
                                    log-remote-lifecycle-events = DEBUG
                                    dot-netty.tcp {
                                        port = 0
                                        hostname = {hostIP}
                                    }
                                }
                                
                                cluster {
                                    allow-weakly-up-members = off
                                    seed-nodes = [""{clusterAddresses}""]
                                    roles = [client]

                                    sharding {
                                        role = sharding
                                        remember-entities = false
                                    }
                                }
                            }";

            hcon = hcon.Replace("{hostIP}", hostIp);
            hcon = hcon.Replace("{clusterAddresses}", $"akka.tcp://testsystem@{clusterPath}:4053");

            Console.WriteLine($"Seed Address:{clusterPath}");

            _clusterSystem = ActorSystem.Create("testsystem", ConfigurationFactory.ParseString(hcon));

            var clusterSharding = ClusterSharding.Get(_clusterSystem);

            var proxy = clusterSharding.StartProxy(
                typeName: "testregion",
                role: "sharding",
                messageExtractor: new MessageExtractor());


            var clientActor = _clusterSystem.ActorOf(ClientActor.Props(), "client");

            clientActor.Ask<DummyResponse>(new DummyRequest(0, 5000)).Wait(); //Warm up 
            
            clientActor.Ask<DummyResponse>(new DummyRequest(0, 100000)).Wait(); //0
            clientActor.Ask<DummyResponse>(new DummyRequest(1, 100000)).Wait(); //1 
            clientActor.Ask<DummyResponse>(new DummyRequest(10, 100000)).Wait(); //10
            clientActor.Ask<DummyResponse>(new DummyRequest(100, 100000)).Wait();//100
            
            clientActor.Ask<DummyResponse>(new DummyRequest(0, 1000000)).Wait(); //10
            clientActor.Ask<DummyResponse>(new DummyRequest(0, 10000000)).Wait();//100
            
            AssemblyLoadContext.Default.Unloading += (obj) => 
            {
                LeaveCluster();
            };

            Console.CancelKeyPress += (s, ev) => 
            {
                LeaveCluster();
            };

            new AutoResetEvent(false).WaitOne();
        }

        public static string GetHostIPAddress(string hostName)
        {
            string hostIP = string.Empty;
            var ipAddressEntries = Dns.GetHostAddresses(hostName);
            hostIP = ipAddressEntries.Where(x => x.AddressFamily == AddressFamily.InterNetwork).First().ToString();
            return hostIP;
        }

        private static void LeaveCluster()
        {
            Console.WriteLine("Leaving cluster");
            CoordinatedShutdown.Get(_clusterSystem).Run().Wait(TimeSpan.FromSeconds(60));
        }
    }
}