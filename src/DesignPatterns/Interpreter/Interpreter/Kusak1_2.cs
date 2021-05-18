using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Kusak1_2 : Expression
    {
        public override void Interpreter(Direnc context)
        {
            string[] basamaklar = context.Input.Split('-');
            string output = "";

            for (int i = 0; i <= renkler.Length - 1; i++)
                if (basamaklar[0] == renkler[i].Renk)
                {
                    output = renkler[i].Rakam;
                    break;
                }
         
            for (int i = 0; i <= renkler.Length - 1; i++)
                if (basamaklar[1] == renkler[i].Renk)
                {
                    output += renkler[i].Rakam;
                    break;
                }

            context.Output = output;
        }
    }
}
