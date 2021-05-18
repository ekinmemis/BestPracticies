using System;

namespace Bridge.Hatali_Tasarim
{
    public class Proskit
    {

        public Kalem KalemHavyaUret()
        {
            Console.WriteLine("Proskit kalem havya üretildi");
            return new Kalem("Proskit");
        }


        public Dijital DijitalAvometreUret()
        {
            Console.WriteLine("Proskit dijital avometre üretildi");
            return new Dijital("Proskit");
        }


        public Analog AnalogAvometreUret()
        {
            Console.WriteLine("Proskit analog avometre üretildi");
            return new Analog();
        }
    }
}
