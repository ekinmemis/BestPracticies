using System;
using System.Collections.Generic;
using System.Text;

namespace StateObserverSingleton
{
    class ThreadMonitor : IObserver
    {
        public void Handle(string threadId, ThreadStateMachine tsm)
        {
            switch (tsm)
            {
                case ThreadStateMachine.StartState:
                    Console.WriteLine("ThreadId: {0} running",threadId);
                    break;
                case ThreadStateMachine.StopState:
                    Console.WriteLine("ThreadId: {0} stopped", threadId);
                    break;
                case ThreadStateMachine.WaitState:
                    Console.WriteLine("ThreadId: {0} waiting", threadId);
                    break;
            }
        }
    }
}
