using System;

namespace Bridge.Hatali_Tasarim
{
    public class Weller
    {

        public Kalem KalemHavyaUret()
        {
            Console.WriteLine("Weller kalem hayva üretildi");
            return new Kalem("Weller");
        }


        public Tabanca TabancaUret()
        {
            Console.WriteLine("Weller tabanca üretildi");
            return new Tabanca();
        }
    }
}
