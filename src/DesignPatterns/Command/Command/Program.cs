using System;

namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shell shell = new Shell();
            for (; ; )
                shell.CommandTest();
        }
    }
}
