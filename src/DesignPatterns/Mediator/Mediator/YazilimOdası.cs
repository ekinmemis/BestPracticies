using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    sealed class YazilimOdası : Oda
    {
        public YazilimOdası() : base() { }

        public override void BroadCastMesajGonder(Katilimci gonderen, string mesaj)
        {
            foreach (Katilimci k in this.katilimcilar)
                k.MesajAl(gonderen, mesaj);
        }

        public override void MesajGonder(Katilimci gonderen, Katilimci alan, string mesaj)
        {
            alan.MesajAl(gonderen, mesaj);
        }

    }
}
