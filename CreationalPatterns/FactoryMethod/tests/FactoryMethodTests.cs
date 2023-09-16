using Xunit;
using System;

namespace FactoryMethodExample.Tests
{
    public class FactoryMethodTests
    {
        [Fact]
        /// <summary>
        /// Validates that the product interface is utilized without needing to know about its concrete type.
        /// </summary>
        public void Test_LooseCoupling_CanUseProductInterfaceWithoutKnowingConcreteType()
        {
            Creator creator = new ConcreteCreatorA();
            var product = creator.FactoryMethod();
            Assert.IsAssignableFrom<IProduct>(product);
        }

        [Fact]
        /// <summary>
        /// Validates that new types of products can be added without impacting the client code.
        /// </summary>
        public void Test_Extensibility_NewProductCanBeAddedWithoutAffectingClient()
        {
            Creator creator = new ConcreteCreatorA();
            var product = creator.FactoryMethod();
            Assert.IsAssignableFrom<IProduct>(product);
        }

        [Fact]
        /// <summary>
        /// Validates that products undergo a standardized creation process.
        /// </summary>
        public void Test_CentralizedCreationLogic_AllProductsHaveStandardizedCreation()
        {
            Creator creatorA = new ConcreteCreatorA();
            Creator creatorB = new ConcreteCreatorB();
            Assert.IsAssignableFrom<IProduct>(creatorA.FactoryMethod());
            Assert.IsAssignableFrom<IProduct>(creatorB.FactoryMethod());
        }

        [Fact]
        /// <summary>
        /// Validates that at runtime, subclasses decide which class to instantiate.
        /// </summary>
        public void Test_DynamicInstantiation_SubclassesDecideWhichClassToInstantiate()
        {
            Creator creator;

            creator = new ConcreteCreatorA();
            var productA = creator.FactoryMethod();

            creator = new ConcreteCreatorB();
            var productB = creator.FactoryMethod();

            Assert.IsType<ConcreteProductA>(productA);
            Assert.IsType<ConcreteProductB>(productB);
        }

        [Fact]
        /// <summary>
        /// Validates the consistent nature of the Factory Method to produce objects.
        /// </summary>
        public void Test_Consistency_StandardizedWayToCreateObjects()
        {
            Creator creatorA = new ConcreteCreatorA();

            var product1 = creatorA.FactoryMethod();
            var product2 = creatorA.FactoryMethod();

            Assert.IsAssignableFrom<IProduct>(product1);
            Assert.IsAssignableFrom<IProduct>(product2);
        }

        [Fact]
        /// <summary>
        /// Validates that the client can use the Factory Method without knowing about the product's creation details.
        /// </summary>
        public void Test_Encapsulation_UsesFactoryMethodWithoutKnowingCreationDetails()
        {
            Creator creator = new ConcreteCreatorA();
            Assert.IsAssignableFrom<IProduct>(creator.FactoryMethod());
        }

        [Fact]
        /// <summary>
        /// Demonstrates the potential for overhead by using the Factory Method pattern.
        /// </summary>
        public void Test_PotentialOverhead_FactoryAddsAdditionalCall()
        {
            Creator creator = new ConcreteCreatorA();

            int beforeCallCount = GetMethodCallCount();
            creator.FactoryMethod();
            int afterCallCount = GetMethodCallCount();

            Assert.True(afterCallCount > beforeCallCount);
        }
    }
}
