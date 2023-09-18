using System;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder builder = new ConcreteBuilder1();
            Client client = new Client();

            Product product = client.RequestProduct(director, builder);

            System.Console.WriteLine(product.ToString());
        }
    }
}