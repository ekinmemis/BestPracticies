using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DBFactory dbFactory = FactoryUtil.GetFactory("Sql");
            Connection connection = dbFactory.CreateConnection();
            Command command = dbFactory.CreateCommand();
            connection.Connect();
            command.Execute();
            command.Query = "Select * from Table1";

            DBFactory dbFactory1 = FactoryUtil.GetFactory("Oracle");
            Connection connection1 = dbFactory1.CreateConnection();
            Command command1 = dbFactory1.CreateCommand();
            connection1.Connect();
            command1.Execute();
            command1.Query = "Select * from Table1";

        }
    }
}
