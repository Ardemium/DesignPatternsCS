/// <summary>
/// Concrete implementation of the AbstractFactory for the first family of products.
/// </summary>
public class ConcreteFactory1 : IAbstractFactory
{
    /// <inheritdoc/>
    public IAbstractProductA CreateProductA()
    {
        return new ProductA1();
    }
    /// <inheritdoc/>
    public IAbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}