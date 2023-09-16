/// <summary>
/// Concrete Creator class to produce ConcreteProductA.
/// </summary>
public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}