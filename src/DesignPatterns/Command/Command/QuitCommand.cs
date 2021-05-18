using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    sealed class QuitCommand:Command
    {
        private Kernel kernel = new Kernel();

        private string path;
        public override string Path { get => ""; set { } }

        public override void Execute()
        {
            kernel.QuitApi();
        }
    }
}
