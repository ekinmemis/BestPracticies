using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    abstract class Katilimci
    {
        private string _nick;
        public string Nick
        {
            get
            {
                return _nick;
            }
            set
            {
                _nick = value;
            }
        }

        protected Katilimci(string nick)
        {
            _nick = nick;
        }

        public abstract void MesajAl(Katilimci gonderen, string mesaj);
    }
}
