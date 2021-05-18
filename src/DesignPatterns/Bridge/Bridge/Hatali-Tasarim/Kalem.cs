using System;

namespace Bridge.Hatali_Tasarim
{
    public class Kalem : Havya
    {
        private Weller tedarikci1;
        private Proskit tedarikci2;

        public Kalem(string marka)
        {
            switch (marka)
            {
                case "Weller":
                    tedarikci1 = new Weller();
                    tedarikci1.KalemHavyaUret();
                    break;
                case "Proskit":
                    tedarikci2 = new Proskit();
                    tedarikci2.KalemHavyaUret();
                    break;
                default:
                    break;
            }
        }

        public override void Lehim()
        {
            Console.WriteLine("Kalem havya ile lehimleme");
        }
    }
}
