using System;

namespace AbstractFactory
{
    class OracleConnection : Connection
    {
        public override string ConnectionString { get => base.connectionString; set => base.connectionString=value; }

        public override void Connect()
        {
            Console.WriteLine("Oracle bağlandı");
        }
    }
}
