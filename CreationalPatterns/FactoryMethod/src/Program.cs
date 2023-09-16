using System;

namespace FactoryMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using ConcreteCreatorA to produce and demonstrate ConcreteProductA
            Creator creatorA = new ConcreteCreatorA();
            creatorA.AnOperation();

            // Using ConcreteCreatorB to produce and demonstrate ConcreteProductB
            Creator creatorB = new ConcreteCreatorB();
            creatorB.AnOperation();
        }
    }
}
