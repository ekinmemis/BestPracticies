using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class ThreadContext
    {
        public IThreadState ThreadState { get; set; }

        public ThreadContext()
        {
            Console.WriteLine("Thread yaratıldı ve henüz çalışmıyor");
            ThreadState = new StoppedState();
        }

        public void Start() => ThreadState.Run(this);
        public void Abort() => ThreadState.Stop(this);
        public void Sleep() => ThreadState.Wait(this);


    }
}
