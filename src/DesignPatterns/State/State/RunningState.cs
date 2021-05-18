using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class RunningState : IThreadState
    {
        public void Run(ThreadContext context)
        {
            Console.WriteLine("Thread zaten çalışır durumda");
        }

        public void Stop(ThreadContext context)
        {
            context.ThreadState = new StoppedState();
            Console.WriteLine("Thread durduruldu");
        }

        public void Wait(ThreadContext context)
        {
            context.ThreadState = new WaitingState();
            Console.WriteLine("Thread geçici olarak çizelgeleme dışına çıkartıldı");
        }
    }
}
