using System;

namespace Bridge
{
    public class ConcreteImplementor1 : Implementor
    {
        public ConcreteImplementor1()
        {
        }

        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementor1::Operation");
        }
    }
}
