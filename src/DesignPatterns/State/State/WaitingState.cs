using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class WaitingState : IThreadState
    {
        public void Run(ThreadContext context)
        {
            context.ThreadState = new RunningState();
            Console.WriteLine("Thread beklemedeyken tekrar çizelgelemeye sokuldu");
        }

        public void Stop(ThreadContext context)
        {
            context.ThreadState = new StoppedState();
            Console.WriteLine("Beklemedeki threadh tümüyle durduruldu");
        }

        public void Wait(ThreadContext context)
        {
            Console.WriteLine("Thread zaten beklemede");
        }
    }
}
