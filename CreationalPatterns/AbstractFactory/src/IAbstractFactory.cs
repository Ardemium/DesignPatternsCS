/// <summary>
/// Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
/// </summary>
public interface IAbstractFactory
{
    /// <summary>
    /// Creates an instance of type AbstractProductA.
    /// </summary>
    /// <returns>An instance of a product of type AbstractProductA.</returns>
    IAbstractProductA CreateProductA();
    /// <summary>
    /// Creates an instance of type AbstractProductB.
    /// </summary>
    /// <returns>An instance of a product of type AbstractProductB.</returns>
    IAbstractProductB CreateProductB();
}