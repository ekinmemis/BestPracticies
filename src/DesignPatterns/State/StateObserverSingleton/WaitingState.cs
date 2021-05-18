using System;
using System.Collections.Generic;
using System.Text;

namespace StateObserverSingleton
{
    class WaitingState : IThreadState
    {
        public static WaitingState _waitingState = null;
        private WaitingState() { }
        public static WaitingState Create()
        {
            if (_waitingState == null)
                _waitingState = new WaitingState();

            return _waitingState;
        }

        public void Run(ThreadContext threadContext)
        {
            threadContext.ThreadState = RunningState.Create();
            Console.WriteLine("Thread beklemedeyken tekrar çizelgelemeye sokuldu");
            threadContext.Notify(threadContext.ThreadId, ThreadStateMachine.StartState);
        }


        public void Stop(ThreadContext threadContext)
        {
            threadContext.ThreadState = StoppedState.Create();
            Console.WriteLine("Beklemedeki thread tümüyle durduruldu");
            threadContext.Notify(threadContext.ThreadId, ThreadStateMachine.StopState);
        }

        public void Wait(ThreadContext threadContext)
        {
            Console.WriteLine("Thread zaten beklemede");
        }
    }
}
