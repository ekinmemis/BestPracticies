using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Direnc
    {
        public Direnc(string input)
        {
            _input = input;
        }
        private string _input;

        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }
        private string _output;

        public string Output
        {
            get { return _output; }
            set { _output = value; }
        }
    }
}
