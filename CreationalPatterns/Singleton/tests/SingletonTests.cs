using System.Threading.Tasks;
using Xunit;

namespace SingletonExample.Tests
{
    /// <summary>
    /// Tests for the Singleton design pattern implementation.
    /// </summary>
    public class SingletonTests
    {
        /// <summary>
        /// Verifies that multiple accesses to the Singleton instance return the same instance.
        /// </summary>
        [Fact]
        public void Singleton_Instance_Returns_Same_Instance()
        {
            // Act
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;

            // Assert
            Assert.Same(instance1, instance2);
        }

        /// <summary>
        /// Ensures that Singleton returns the same instance even when accessed from multiple threads.
        /// </summary>
        [Fact]
        public void Singleton_MultipleThreads_Returns_Same_Instance()
        {
            // Arrange
            Singleton instance1 = null;
            Singleton instance2 = null;

            // Act
            var task1 = Task.Run(() => { instance1 = Singleton.Instance; });
            var task2 = Task.Run(() => { instance2 = Singleton.Instance; });

            Task.WaitAll(task1, task2);

            // Assert
            Assert.Same(instance1, instance2);
        }

        /// <summary>
        /// Validates that the Singleton's constructor is private and can't be called directly.
        /// </summary>
        [Fact]
        public void Singleton_Cannot_Be_Created_Directly()
        {
            var constructor = typeof(Singleton).GetConstructor(
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, new Type[0], null);

            // Assert
            Assert.True(constructor.IsPrivate);
        }
    }
}