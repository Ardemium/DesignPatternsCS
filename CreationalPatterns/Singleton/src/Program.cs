using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Retrieving the Singleton instance
            Singleton singleInstance1 = Singleton.Instance;
            singleInstance1.DisplayMessage();

            // Retrieving the Singleton instance again
            Singleton singleInstance2 = Singleton.Instance;
            singleInstance2.DisplayMessage();

            // Checking if both retrieved instances are the same
            if (ReferenceEquals(singleInstance1, singleInstance2))
            {
                Console.WriteLine("The two instances are the same.");
            }
            else
            {
                Console.WriteLine("Different instances.");
            }
        }
    }
}