using System;

namespace Bridge.Hatali_Tasarim
{
    public class TasinabilirOsiloskop : Osiloskop
    {
        private Fluke fluke = new Fluke();

        public TasinabilirOsiloskop()
        {
            fluke.TasinabilirOsiloskopUret();
        }

        public override void EkranaCiz()
        {
            Console.WriteLine("El tipi osiloskop");
        }
    }
}
