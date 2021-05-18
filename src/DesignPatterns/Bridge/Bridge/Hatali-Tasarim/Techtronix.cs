using System;

namespace Bridge.Hatali_Tasarim
{
    public class Techtronix
    {

        public StandartOsiloskop StandartOsiloskopUret()
        {
            Console.WriteLine("Techtronix standart osiloskop üretildi");
            return new StandartOsiloskop();
        }


        public TasinabilirOsiloskop  TasinabilirOsiloskopUret()
        {
            Console.WriteLine("Techtronix taşınabilir osiloskop üretildi");
            return new TasinabilirOsiloskop();
        }
    }
}
