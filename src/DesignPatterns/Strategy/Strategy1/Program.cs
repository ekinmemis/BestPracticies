using System;
using System.Data;

namespace Strategy1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Sales.CurrencyRate", "server=.,database=AdventureWorks;uid=sa;pwd=superuser");

            DataTable table1 = new DataTable("Kurlar");
            adp.Fill(table1);

            SerializeContext serializeContext = new SerializeContext(new SoapStrategy(table1));
            serializeContext.Save("path1");

            serializeContext = new SerializeContext(new XmlStrategy(table1));
            serializeContext.Save("path2");

            table1.RemotingFormat = SerializationFormat.Binary;
            serializeContext = new SerializeContext(new BinaryStrategy(table1));
            serializeContext.Save("path3");
        }
    }
}
