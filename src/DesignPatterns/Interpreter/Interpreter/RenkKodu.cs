using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class RenkKodu
    {
        private string _renk;

        private string _rakam;
        
        public string Renk
        {
            get { return _renk; }
            set { _renk = value; }
        }

        public string Rakam
        {
            get { return _rakam; }
            set { _rakam = value; }
        }

        public RenkKodu(string rakam,string renk)
        {
            _renk = renk;
            _rakam = rakam;
        }
    }
}
