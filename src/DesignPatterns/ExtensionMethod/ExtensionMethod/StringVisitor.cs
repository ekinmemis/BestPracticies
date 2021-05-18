using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    static class StringVisitor
    {
        public static void Display(this string str,int adet)
        {
            for (int i = 0; i <= adet; i++)
                Console.WriteLine(str);
        }
    }
}
