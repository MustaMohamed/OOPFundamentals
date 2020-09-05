using System;
using System.Collections.Generic;

namespace Singleton
{
    public class ModernLoadBalancer
    {
        private static readonly ModernLoadBalancer _instance = new ModernLoadBalancer();
        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        // Constructor (private)
        private ModernLoadBalancer()
        {
            // Load list of available servers
            _servers = new List<Server>
            {
                new Server {Name = "Server #1", Ip = "120.14.220.18"},
                new Server {Name = "Server #2", Ip = "120.14.220.19"},
                new Server {Name = "Server #3", Ip = "120.14.220.20"},
                new Server {Name = "Server #4", Ip = "120.14.220.21"},
                new Server {Name = "Server #5", Ip = "120.14.220.22"},
            };
        }

        public static ModernLoadBalancer GetLoadBalancer()
        {
            return _instance;
        }

        // Simple, but effective random load balancer
        public Server Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }

    /// <summary>
    /// Represents a server machine
    /// </summary>
    public class Server
    {
        // Gets or sets server name
        public string Name { get; set; }

        // Gets or sets server IP address
        public string Ip { get; set; }
    }
}