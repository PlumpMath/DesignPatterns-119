using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine("this.GetType()" + this.GetType() + ". this.GetType().Name" + this.GetType().Name);
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
