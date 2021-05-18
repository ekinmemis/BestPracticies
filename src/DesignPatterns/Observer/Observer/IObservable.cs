using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObservable 
    {
        void Register(Kontrol k);
        void UnRegister(Kontrol k);
        void Notify();
    }
}
