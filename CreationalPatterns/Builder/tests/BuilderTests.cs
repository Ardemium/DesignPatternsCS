using Xunit;
namespace BuilderExample.Tests
{
    public class BuilderTests
    {
        [Fact]
        public void Test_SeparationOfConcerns()
        {
            // Construction and representation are separated.
            Builder builder = new ConcreteBuilder1();
            Director director = new Director();
            director.SetBuilder(builder);
            director.ConstructProduct();

            Product product = builder.GetProduct();

            Assert.NotNull(product);
            Assert.Equal("Part A Value", product.PartA);
            Assert.Equal("Part B Value", product.PartB);
        }

        [Fact]
        public void Test_Variability()
        {
            // Different representations can be built using the same process.
            Builder builder1 = new ConcreteBuilder1();
            // Imagine another builder like ConcreteBuilder2.

            Director director = new Director();
            director.SetBuilder(builder1);
            director.ConstructProduct();

            Product product1 = builder1.GetProduct();
            // Product product2 = builder2.GetProduct();

            Assert.Equal("Part A Value", product1.PartA);
            // Assert.Equal("Another Part A Value", product2.PartA);
        }
    }
}