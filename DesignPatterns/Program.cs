using DesignPatterns.Patterns.AbstractFactory;
using DesignPatterns.Patterns.Bridge;
using DesignPatterns.Patterns.FactoryMethod;
using DesignPatterns.Patterns.Singleton;
using DesignPatterns.Patterns.Singleton.Optimized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract factory design pattern
            TestAbstractFactory tbf = new TestAbstractFactory();
            tbf.Run();

            //factory method design pattern
            TestFactoryMethod tfm = new TestFactoryMethod();
            tfm.Run();

            //Singleton design pattern
            TestSingleton ts = new TestSingleton();
            ts.Run();

            TestOptimizedSingleton tos = new TestOptimizedSingleton();
            tos.Run();

            //Bridge design pattern
            TestBridge tb = new TestBridge();
            tb.Run();
        }
    }
}
