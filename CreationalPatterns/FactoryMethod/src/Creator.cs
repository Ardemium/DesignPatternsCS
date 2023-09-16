/// <summary>
/// Represents the abstract Creator class for the Factory Method pattern.
/// </summary>
public abstract class Creator
{
    /// <summary>
    /// The Factory Method that concrete creators will override to produce specific products.
    /// </summary>
    public abstract IProduct FactoryMethod();

    /// <summary>
    /// A demonstration of a method that uses the Factory Method to create and interact with products.
    /// </summary>
    public void AnOperation()
    {
        var product = FactoryMethod();
        product.Operation();
    }
}