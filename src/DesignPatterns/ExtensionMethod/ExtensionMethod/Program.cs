using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "ekin";
            StringVisitor.Display(name, 10);
        }
    }
}
