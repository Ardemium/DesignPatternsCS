/// <summary>
/// Concrete implementation of the AbstractFactory for the second family of products.
/// </summary>
public class ConcreteFactory2 : IAbstractFactory
{
    /// <inheritdoc/>
    public IAbstractProductA CreateProductA()
    {
        return new ProductA2();
    }
    /// <inheritdoc/>
    public IAbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}