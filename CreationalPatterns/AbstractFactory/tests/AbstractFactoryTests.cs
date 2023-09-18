using Xunit;

namespace AbstractFactoryExample.Tests
{
    /// <summary>
    /// Tests for the Abstract Factory design pattern implementation.
    /// </summary>
    public class AbstractFactoryTests
    {
        /// <summary>
        /// Ensures that products from one family are used together.
        /// </summary>
        [Fact]
        public void Factory_Produces_Consistent_Product_Family()
        {
            // Act
            IAbstractFactory factory1 = new ConcreteFactory1();
            var productA1 = factory1.CreateProductA();
            var productB1 = factory1.CreateProductB();

            // Assert
            Assert.IsType<ProductA1>(productA1);
            Assert.IsType<ProductB1>(productB1);
        }

        /// <summary>
        /// Verifies that product creation is separated from its use.
        /// </summary>
        [Fact]
        public void Factory_Separates_Creation_From_Use()
        {
            // Act & Assert
            IAbstractFactory factory = new ConcreteFactory1();

            // Only knowing the abstract interfaces, not the concrete implementations
            IAbstractProductA productA;
            IAbstractProductB productB;

            // Creation separated from usage
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();

            Assert.NotNull(productA);
            Assert.NotNull(productB);
        }

        /// <summary>
        /// Ensures the ability to easily swap between different product families.
        /// </summary>
        [Fact]
        public void Factory_Supports_Exchangeability_Of_Product_Families()
        {
            // Arrange
            IAbstractFactory factory1 = new ConcreteFactory1();
            IAbstractFactory factory2 = new ConcreteFactory2();

            // Act
            var productA1 = factory1.CreateProductA();
            var productB1 = factory1.CreateProductB();

            var productA2 = factory2.CreateProductA();
            var productB2 = factory2.CreateProductB();

            // Assert
            Assert.IsType<ProductA1>(productA1);
            Assert.IsType<ProductB1>(productB1);
            Assert.IsType<ProductA2>(productA2);
            Assert.IsType<ProductB2>(productB2);
        }
    }
}