using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    sealed class DelCommand:Command
    {
        private Kernel kernel = new Kernel();

        private string path;
        public override string Path { get => path; set => path = value; }

        public override void Execute()
        {
            kernel.DeleteApi(path);
        }
    }
}
