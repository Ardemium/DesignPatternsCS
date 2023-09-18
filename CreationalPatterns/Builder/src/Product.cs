// Product.cs

/// <summary>
/// Represents a semi-immutable product with multiple parts.
/// </summary>
public class Product
{
    private string partA;
    private string partB;

    /// <summary>
    /// Gets or sets the PartA of the product. Can only be set once.
    /// </summary>
    public string PartA 
    { 
        get => partA;
        set 
        {
            if (partA == null) 
                partA = value;
            else
                System.Console.WriteLine("PartA has already been set and cannot be modified.");
        }
    }

    /// <summary>
    /// Gets or sets the PartB of the product. Can only be set once.
    /// </summary>
    public string PartB 
    { 
        get => partB;
        set 
        {
            if (partB == null) 
                partB = value;
            else
                System.Console.WriteLine("PartB has already been set and cannot be modified.");
        }
    }

    public override string ToString()
    {
        return $"Product with PartA: {PartA} and PartB: {PartB}";
    }
}
