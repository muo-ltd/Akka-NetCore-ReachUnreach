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

namespace Client
{
    public class MessageProcessor
    {
        public void DoSomeWork()
        {
            const int max = 1000;

            //Bad prime code
            var noPrime = new List<int>();
            var primeCode = new List<int>();

            for(int x = 2; x < max;x++)
            {
                for(int y = x * 2;y < max;y = y + x)
                {    
                    if(!noPrime.Contains(y))
                    {
                        noPrime.Add(y);
                    }    
                }    
            }

            for(int z = 2; z < max;z++)
            {
                if(!noPrime.Contains(z))
                {
                    if (!primeCode.Contains(z))
                    {
                        primeCode.Add(z);
                    }
                }
            }
        }
    }
}