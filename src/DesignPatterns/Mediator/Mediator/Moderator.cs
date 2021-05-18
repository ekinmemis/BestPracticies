using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Moderator:Katilimci
    {
        public Moderator(string nick) : base(nick)
        {

        }

        public override void MesajAl(Katilimci gonderen, string mesaj)
        {
            Console.WriteLine("{0} -> {1} : {2}", gonderen.Nick, this.Nick, mesaj);
        }
    }
}
