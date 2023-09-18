using System;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using ConcreteFactory1
            IAbstractFactory factory1 = new ConcreteFactory1();
            var productA1 = factory1.CreateProductA();
            var productB1 = factory1.CreateProductB();

            Console.WriteLine($"Created {productA1.GetType().Name} using {factory1.GetType().Name}");
            Console.WriteLine($"Created {productB1.GetType().Name} using {factory1.GetType().Name}");

            // Using ConcreteFactory2
            IAbstractFactory factory2 = new ConcreteFactory2();
            var productA2 = factory2.CreateProductA();
            var productB2 = factory2.CreateProductB();

            Console.WriteLine($"Created {productA2.GetType().Name} using {factory2.GetType().Name}");
            Console.WriteLine($"Created {productB2.GetType().Name} using {factory2.GetType().Name}");

        }
    }
}