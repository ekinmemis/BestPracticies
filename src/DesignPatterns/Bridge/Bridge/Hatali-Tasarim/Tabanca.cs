using System;

namespace Bridge.Hatali_Tasarim
{
    public class Tabanca:Havya
    {
        private Weller tedarikci;
        public Tabanca()
        {
            tedarikci = new Weller();
            tedarikci.KalemHavyaUret();
        }

        public override void Lehim()
        {
            Console.WriteLine("Tabanca havya ile lehimleme");
        }
    }
}
