using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadContext thread = new ThreadContext();

            thread.Start();
            thread.Start();
            thread.Sleep();
            thread.Start();
            thread.Abort();
            thread.Start();
            thread.Abort();
            thread.Abort();
        }
    }
}
