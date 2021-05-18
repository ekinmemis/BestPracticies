using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class CallCenter
    {
        private List<Operator> acenta = new List<Operator>();

        public CallCenter()
        {
            Operator o = new Operator("ekin");
            Operator o1 = new Operator("muhammed");
            Operator o2 = new Operator("tugay");

            o.Durum = false;//müsait değil
            o1.Durum = false;//müsait değil
            o2.Durum = true;//müsait

            o.SonrakiOperator = o1;
            o1.SonrakiOperator = o2;
            
            Operator[] operators = { o, o1, o2 };
            acenta.AddRange(operators);
        }

        public void CagriAl()
        {
            //ilk operatör çağrıyı cevaplasın
            acenta[0].CagriCevapla();
        }

    }
}
