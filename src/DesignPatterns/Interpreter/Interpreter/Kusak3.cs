using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Kusak3 : Expression
    {

        public override void Interpreter(Direnc context)
        {
            string[] basamaklar = context.Input.Split('-');
            string output = context.Output;

            for (int i = 0; i <= carpanlar.Length - 1;i++)
                if (basamaklar[2] == carpanlar[i].Renk)
                {
                    output = (Convert.ToInt32(output) + Convert.ToInt64(carpanlar[i].Rakam)).ToString();
                    break;
                }

            output += " ohm.";
            context.Output = output;
        }
    }
}
