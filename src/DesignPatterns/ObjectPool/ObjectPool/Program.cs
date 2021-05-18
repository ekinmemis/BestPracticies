using System;

namespace ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Connection connection1 = new Connection("connectionString1");
            connection1.Open();
            connection1.Execute("query1");
            connection1.Close();

            Connection connection2 = new Connection("connectionString2");
            connection2.Open();
            connection2.Execute("query2");
            connection2.Close();

            Connection connection3 = new Connection("connectionString3");
            connection3.Open();
            connection3.Execute("query3");
            connection3.Close();
        }
    }
}
