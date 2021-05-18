using System;
using System.Collections.Generic;
using System.Text;

namespace StateObserverSingleton
{
    interface IThreadState
    {
        void Run(ThreadContext threadContext);
        void Stop(ThreadContext threadContext);
        void Wait(ThreadContext threadContext);
    }
}
