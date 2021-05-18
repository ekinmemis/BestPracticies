using Finans;
using System;

namespace VirtualConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            TCDarphane darphane = new TCDarphane();
            Tl tl = (Tl)darphane.ParaBas(200);
            
            if (tl.NominalDeger == "200 TL BASILDI!")
                Console.WriteLine("Benim oğlum para babası :)");
            else
                Console.WriteLine(tl.NominalDeger);
        }
    }
}
