using System;
using System.Collections.Generic;
using System.Text;

namespace StateObserverSingleton
{
    interface IObservable
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
        void Notify(string threadId,ThreadStateMachine tsm);

    }
}
