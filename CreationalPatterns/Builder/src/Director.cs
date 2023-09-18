/// <summary>
/// The director class that constructs products.
/// </summary>
public class Director
{
    private Builder builder;

    /// <summary>
    /// Sets the builder for product construction.
    /// </summary>
    public void SetBuilder(Builder builder)
    {
        this.builder = builder;
    }

    /// <summary>
    /// Constructs a product using the set builder.
    /// </summary>
    public void ConstructProduct()
    {
        builder.BuildPartA("Part A Value");
        builder.BuildPartB("Part B Value");
    }
}