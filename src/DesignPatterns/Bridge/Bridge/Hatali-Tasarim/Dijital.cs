using System;

namespace Bridge.Hatali_Tasarim
{
    public class Dijital : Avometre
    {
        private Proskit tedarikci1;
        private Fluke tedarikci2;

        public Dijital(string marka)
        {
            switch (marka)
            {
                case "Proskit":
                    tedarikci1 = new Proskit();
                    tedarikci1.DijitalAvometreUret();
                    break;
                case "Fluke":
                    tedarikci2 = new Fluke();
                    tedarikci2.DijitalAvometreUret();
                    break;
            }
        }

        public override void DirencOlcumu()
        {
            Console.WriteLine("Dijital avometre ile direnç ölçümü");
        }
    }
}
