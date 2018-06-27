using System;
using System.Net;
using System.Threading;
using Akka.Actor;
using Akka.Configuration;
using Serilog;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using Serilog.Core;
using Serilog.Events;

namespace Lighthouse
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
                                        port = 4053
                                        hostname = {hostIP}
                                    }
                                }
                                
                                cluster {
                                    allow-weakly-up-members = off
                                    seed-nodes = [""{clusterAddresses}""]
                                    roles = [lighhouse]

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

            Console.WriteLine("Running");

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