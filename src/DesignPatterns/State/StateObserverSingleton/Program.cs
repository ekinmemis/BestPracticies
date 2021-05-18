using System;

namespace StateObserverSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadContext threadContext = new ThreadContext();
            ThreadMonitor threadMonitor = new ThreadMonitor();

            threadContext.Register(threadMonitor);

            threadContext.Start();
            threadContext.Start();
            threadContext.Sleep();
            threadContext.Start();
            threadContext.Abort();
            threadContext.Start();
            threadContext.Abort();
            threadContext.Abort();
        }
    }
}
