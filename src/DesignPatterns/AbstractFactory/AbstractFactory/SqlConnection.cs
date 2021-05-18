using System;

namespace AbstractFactory
{
    class SqlConnection : Connection
    {
        public override string ConnectionString { get => base.connectionString; set => base.connectionString=value; }

        public override void Connect()
        {
            Console.WriteLine("Sql bağlandı");
        }
    }
}
