using System;

namespace Bridge.Hatali_Tasarim
{
    public class StandartOsiloskop : Osiloskop
    {
        private Techtronix techtronix = new Techtronix();

        public StandartOsiloskop()
        {
            techtronix.StandartOsiloskopUret();
        }

        public override void EkranaCiz()
        {
            Console.WriteLine("Normal osiloskop");
        }
    }
}
