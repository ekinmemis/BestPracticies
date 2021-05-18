using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Kusak4 : Expression
    {
        public override void Interpreter(Direnc context)
        {
            string[] basamaklar = context.Input.Split('-');
            string output = context.Output;

            for(int i = 0; i <= toleranslar.Length - 1; i++)
                if(basamaklar[3]==toleranslar[i].Renk)
                {
                    output += " %" + toleranslar[i].Rakam + " toleransla";
                    break;
                }

            context.Output = output;
        }
    }
}
