using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade.Current.Func();
            Facade.Current.DoWork();
            Facade.Current.Sample();
            Facade.Current.Subsystem1.Foo();
            Facade.Current.Subsystem3.Tar();
        }
    }
}
