using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface IThreadState
    {
        void Run(ThreadContext context);
        void Stop(ThreadContext context);
        void Wait(ThreadContext context);
    }
}
