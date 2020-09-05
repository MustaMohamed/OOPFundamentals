using System;
using System.Collections.Generic;

namespace Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        // Lock synchronization object
        private static object syncLock = new object();

        // Constructor (private)
        private LoadBalancer()
        {
            // List of available servers
            _servers.Add("Server 1");
            _servers.Add("Server 2");
            _servers.Add("Server 3");
            _servers.Add("Server 4");
            _servers.Add("Server 5");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multi-threaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}