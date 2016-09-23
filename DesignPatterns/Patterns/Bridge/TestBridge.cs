using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Bridge
{
    public class TestBridge
    {
        public void Run()
        {
            // Create RefinedAbstraction
            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomersData();

            // Exercise the bridge
            //customers.Show();
            //customers.Next();
            //customers.Show();
            //customers.Next();
            //customers.Show();
            customers.Add("Henry Velasquez");

            customers.Delete("Jim Jones");
            customers.Data.ShowAllRecords();
            //customers.ShowAll();

            // Wait for user
            Console.ReadKey();
        }
    }
}
