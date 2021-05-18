using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    abstract class Command
    {
        public abstract string Path { get; set; }
        public abstract void Execute();

    }
}
