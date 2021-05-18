using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] parts1 = { "a", "b", "c" };
            string[] parts2 = { "1", "2", "3" };

            Builder builder = new ConcreteBuilder1();
            Director.Construct(builder, parts1);
            Product p = builder.GetProduct();
            Console.WriteLine(p.ToString());

            builder = new ConcreteBuilder2();
            Director.Construct(builder, parts2);
            Product p2 = builder.GetProduct();
            Console.WriteLine(p2.ToString());

            

        }
    }
}
