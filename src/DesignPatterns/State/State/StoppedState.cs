using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class StoppedState : IThreadState
    {
        public void Run(ThreadContext context)
        {
            context.ThreadState = new RunningState();
            Console.WriteLine("Thread çalışmaya başladı");
        }

        public void Stop(ThreadContext context)
        {
            Console.WriteLine("Thread zaten durdurulmuş durumda");
        }

        public void Wait(ThreadContext context)
        {
            Console.WriteLine("Duran bir thread beklemeye alınamaz");
        }
    }
}
