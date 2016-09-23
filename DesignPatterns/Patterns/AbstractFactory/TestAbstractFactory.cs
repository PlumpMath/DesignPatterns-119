using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AbstractFactory
{
    public class TestAbstractFactory
    {
        /*
         * Participants
            The classes and objects participating in this pattern are:
            AbstractFactory  (ContinentFactory)
            declares an interface for operations that create abstract products
            ConcreteFactory   (AfricaFactory, AmericaFactory)
            implements the operations to create concrete product objects
            AbstractProduct   (Herbivore, Carnivore)
            declares an interface for a type of product object
            Product  (Wildebeest, Lion, Bison, Wolf)
            defines a product object to be created by the corresponding concrete factory
            implements the AbstractProduct interface
            Client  (AnimalWorld)
            uses interfaces declared by AbstractFactory and AbstractProduct classes
         */
         public void Run()
        {
            // Abstract factory #1
            ContientFactory factory1 = new AfricaFactory();
            AnimalWorld client1 = new AnimalWorld(factory1);
            client1.RunFoodChain();

            // Abstract factory #2
            ContientFactory factory2 = new AmericaFactory();
            AnimalWorld client2 = new AnimalWorld(factory2);
            client2.RunFoodChain();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
