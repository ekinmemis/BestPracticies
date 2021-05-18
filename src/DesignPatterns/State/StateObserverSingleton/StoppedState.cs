using System;
using System.Collections.Generic;
using System.Text;

namespace StateObserverSingleton
{
    class StoppedState:IThreadState
    {
        public static StoppedState _stoppedState = null;
        private StoppedState() { }
        public static StoppedState Create()
        {
            if (_stoppedState == null)
                _stoppedState = new StoppedState();

            return _stoppedState;
        }

        public void Run(ThreadContext threadContext)
        {
            threadContext.ThreadState = RunningState.Create();
            Console.WriteLine("Thread çalışmaya başladı");
            threadContext.Notify(threadContext.ThreadId, ThreadStateMachine.StartState);
        }


        public void Stop(ThreadContext threadContext)
        {
            Console.WriteLine("Thread zaten durdurulmuş");
        }

        public void Wait(ThreadContext threadContext)
        {
            Console.WriteLine("Duran bir thread beklemeye alınamaz.");
        }
    }
}
