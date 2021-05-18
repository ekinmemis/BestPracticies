using System;

namespace Builder1
{
    class Musteri
    {
        public static void ArabaIstegi(Markalar markalar, string model, params string[] parcalar)
        {
            Acenta acenta = new Acenta();
            switch (markalar)
            {
                case Markalar.BMW:
                    Bmw bmw = Acenta.BmwTalebi(model, parcalar);
                    Console.WriteLine(bmw.ToString());
                    break;
                case Markalar.AUDI:
                    Audi audi = Acenta.AudiTalebi(model, istek_parcalar);
                    Console.WriteLine(audi.ToString());
                    break;
            }
        }
    }
}
