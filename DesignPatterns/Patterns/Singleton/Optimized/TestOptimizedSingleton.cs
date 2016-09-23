using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Singleton.Optimized
{
    class TestOptimizedSingleton
    {
        public void Run()
        {
            OptimizedLoadBalancer b1 = OptimizedLoadBalancer.GetLoadBalancer();
            OptimizedLoadBalancer b2 = OptimizedLoadBalancer.GetLoadBalancer();
            OptimizedLoadBalancer b3 = OptimizedLoadBalancer.GetLoadBalancer();
            OptimizedLoadBalancer b4 = OptimizedLoadBalancer.GetLoadBalancer();

            // Confirm these are the same instance
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Next, load balance 15 requests for a server
            OptimizedLoadBalancer balancer = OptimizedLoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string serverName = balancer.NextServer.Name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
