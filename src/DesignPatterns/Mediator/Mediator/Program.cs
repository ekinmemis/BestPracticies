using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Katilimci katilimci1 = new NormalKatilimci("ekin");
            Katilimci katilimci2 = new NormalKatilimci("muhammed");
            Katilimci katilimci3 = new NormalKatilimci("tugay");
            Katilimci katilimci4 = new Moderator("moderator");

            YazilimOdası oda = new YazilimOdası();
            oda.KatilimciEkle(katilimci1);
            oda.KatilimciEkle(katilimci2);
            oda.KatilimciEkle(katilimci3);
            oda.KatilimciEkle(katilimci4);

            oda.BroadCastMesajGonder(katilimci4, "Merhaba arkadaşlar");
            Console.WriteLine();
            oda.MesajGonder(katilimci1, katilimci2, "yapmam gereken işleri bitirdim, yeni iş veya yardıma ihtiyacı olan varsa ilgilenebilirim");
            oda.MesajGonder(katilimci2, katilimci1, "en kısa sürede seni bilgilendiricem\n");

            oda.MesajGonder(katilimci3, katilimci2, "naptın,müsaitmisin");
            oda.MesajGonder(katilimci2, katilimci3, "müsaitim sana nasıl yardımcı olabilirim");
        }
    }
}
