using System;

namespace AbstractFactory
{
    class OracleCommand : Command
    {
        public override string Query { get => base.query; set => base.query=value; }

        public override void Execute()
        {
            Console.WriteLine("Pl/Sql çalıştı");
        }
    }
}
