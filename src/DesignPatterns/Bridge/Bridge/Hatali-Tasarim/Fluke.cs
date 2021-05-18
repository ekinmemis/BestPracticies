using System;

namespace Bridge.Hatali_Tasarim
{
    public class Fluke
    {

        public Dijital DijitalAvometreUret()
        {
            Console.WriteLine("Fluke dijital avometre üretildi");
            return new Dijital("Fluke");
        }


        public TasinabilirOsiloskop  TasinabilirOtiloskopUret()
        {
            Console.WriteLine("Fluke taşınabilir osiloskop üretildi");
            return new TasinabilirOsiloskop();
        }
    }
}
