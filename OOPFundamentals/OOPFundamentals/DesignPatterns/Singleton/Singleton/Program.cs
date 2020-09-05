using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSingletonBasicExample();
            Console.WriteLine();
            RunSingletonLoadBalancerExample();
            Console.WriteLine();
            RunSingletonModernLoadBalancerExample();
        }

        static void RunSingletonBasicExample()
        {
            Console.WriteLine("Welcome to basic Singleton design pattern example.!");
            // Constructor is protected -- cannot use new
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance.");
            }
        }

        static void RunSingletonLoadBalancerExample()
        {
            Console.WriteLine("Welcome to real-world (Load Balancer) Singleton design pattern example.!");

            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }
        }

        static void RunSingletonModernLoadBalancerExample()
        {
            Console.WriteLine("Welcome to real-world (Modern Load Balancer) Singleton design pattern example.!");

            var b1 = ModernLoadBalancer.GetLoadBalancer();
            var b2 = ModernLoadBalancer.GetLoadBalancer();
            var b3 = ModernLoadBalancer.GetLoadBalancer();
            var b4 = ModernLoadBalancer.GetLoadBalancer();

            // Confirm these are the same instance
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Next, load balance 15 requests for a server
            var balancer = ModernLoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string serverName = balancer.Server.Name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }
        }
    }
}