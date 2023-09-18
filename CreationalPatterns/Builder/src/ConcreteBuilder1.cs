/// <summary>
/// A concrete builder implementation.
/// </summary>
public class ConcreteBuilder1 : Builder
{
    private Product product = new Product();

    public override void BuildPartA(string value)
    {
        product.PartA = value;
    }

    public override void BuildPartB(string value)
    {
        product.PartB = value;
    }

    public override Product GetProduct()
    {
        return product;
    }
}
