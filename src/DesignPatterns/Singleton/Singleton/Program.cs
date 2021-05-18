using System;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sample3 obj1 = Sample3.CreateObject();
            Sample3 obj2 = Sample3.CreateObject();
            Sample3 obj3 = Sample3.CreateObject();

            obj1.Value = 26091999;

            Console.WriteLine("obj1.Value = {0}", obj1.Value);
            Console.WriteLine("obj2.Value = {0}", obj2.Value);
            Console.WriteLine("obj3.Value = {0}", obj3.Value);

            //Out : obj1.Value = 26091999
            //      obj2.Value = 26091999
            //      obj3.Value = 26091999
        }
    }
}
