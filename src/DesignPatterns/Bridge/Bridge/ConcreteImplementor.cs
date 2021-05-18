using System;

namespace Bridge
{
    public class ConcreteImplementor : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementor::Operation");
        }
    }
}
