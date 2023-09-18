/// <summary>
/// The abstract builder class.
/// </summary>
public abstract class Builder
{
    public abstract void BuildPartA(string value);
    public abstract void BuildPartB(string value);
    public abstract Product GetProduct();
}