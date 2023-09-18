/// <summary>
/// The client class that requests a product.
/// </summary>
public class Client
{
    public Product RequestProduct(Director director, Builder builder)
    {
        director.SetBuilder(builder);
        director.ConstructProduct();
        return builder.GetProduct();
    }
}