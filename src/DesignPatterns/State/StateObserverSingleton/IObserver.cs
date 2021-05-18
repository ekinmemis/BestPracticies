using System;
using System.Collections.Generic;
using System.Text;

namespace StateObserverSingleton
{
    interface IObserver
    {
        void Handle(string threadId, ThreadStateMachine tsm);
    }
}
