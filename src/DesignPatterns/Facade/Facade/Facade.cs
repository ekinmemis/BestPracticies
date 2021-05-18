using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Facade
    {
        private Subsystem1 _subsystem1;
        private Subsystem2 _subsystem2;
        private Subsystem3 _subsystem3;
        private static Facade _facade = null;

        public Subsystem1 Subsystem1 { get => _subsystem1; }
        public Subsystem2 Subsystem2 { get => _subsystem2; }
        public Subsystem3 Subsystem3 { get => _subsystem3; }
        public Facade()
        {
            _subsystem1 = new Subsystem1();
            _subsystem2 = new Subsystem2();
            _subsystem3 = new Subsystem3();
        }

        public static Facade Current { get { return CreateFacade(); } }
        public static Facade CreateFacade()
        {
            if (_facade == null)
                _facade = new Facade();
            return _facade;
        }


        public void Sample()
        {
            _subsystem1.Foo();
            _subsystem2.Bar();
        }


        public void DoWork()
        {
            SubSystem4.Zet();
        }


        public void Func()
        {
            _subsystem3.Tar();
        }
    }
}
