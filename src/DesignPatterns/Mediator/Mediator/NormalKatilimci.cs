using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class NormalKatilimci : Katilimci
    {
        public NormalKatilimci(string nick) : base(nick) { }

        public override void MesajAl(Katilimci gonderen, string mesaj)
        {
            Console.WriteLine("{0} -> {1} : {2}", gonderen.Nick, this.Nick, mesaj);
        }


    }
}
