using System;

namespace AbstractFactory
{
    class SqlCommand : Command
    {
        public override string Query { get => base.query; set => base.query = value; }

        public override void Execute()
        {
            Console.WriteLine("T-sql çalıştı ");
        }
    }
}
