/// <summary>
/// Concrete Creator class to produce ConcreteProductB.
/// </summary>
public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}