/// <summary>
/// A Singleton design pattern implementation.
/// </summary>
public sealed class Singleton
{
    // Used for thread-safe lock during lazy initialization
    private static readonly object lockObject = new object();

    // Represents the single instance of the Singleton class
    private static Singleton instance = null;

    /// <summary>
    /// Private constructor ensures that no instance can be created from outside the class.
    /// </summary>
    private Singleton() { }

    /// <summary>
    /// Gets the singleton instance, with a double-checked locking mechanism to ensure thread safety.
    /// </summary>
    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    // Double-check pattern is used to prevent unnecessary locking once instance is initialized
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }

    /// <summary>
    /// Displays a sample message from the Singleton instance.
    /// </summary>
    public void DisplayMessage()
    {
        Console.WriteLine("Hello from the Singleton instance!");
    }
}