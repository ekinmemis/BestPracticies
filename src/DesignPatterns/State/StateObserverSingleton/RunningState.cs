using System;
using System.Collections.Generic;
using System.Text;

namespace StateObserverSingleton
{
    class RunningState : IThreadState
    {
        public static RunningState _runningState = null;
        private RunningState() { }
        public static RunningState Create()
        {
            if (_runningState == null)
                _runningState = new RunningState();

            return _runningState;
        }

        public void Run(ThreadContext threadContext)
        {
            Console.WriteLine("Thread zaten çalışır durumda");
        }


        public void Stop(ThreadContext threadContext)
        {
            threadContext.ThreadState = StoppedState.Create();
            Console.WriteLine("Thread durduruldu");
            threadContext.Notify(threadContext.ThreadId, ThreadStateMachine.StopState);
        }

        public void Wait(ThreadContext threadContext)
        {
            threadContext.ThreadState = WaitingState.Create();
            Console.WriteLine("Thread geçici olarak çizelge dışına alındı");
            threadContext.Notify(threadContext.ThreadId, ThreadStateMachine.WaitState);
        }
    }
}
