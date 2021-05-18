using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            Database clonedDatabase = (Database)database.Clone();/*önemli nokta burası*/
            clonedDatabase.Name = "ClonedDatabase";
            clonedDatabase.AddTable("Table1");
            Console.WriteLine(clonedDatabase.Name);
            clonedDatabase.TableList();



        }
    }
}
