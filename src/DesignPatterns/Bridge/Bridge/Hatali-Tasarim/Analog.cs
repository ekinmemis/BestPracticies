using System;

namespace Bridge.Hatali_Tasarim
{
    public class Analog : Avometre
    {
        private Proskit proskit = new Proskit();

        public Analog()
        {
            proskit.AnalogAvometreUret();
        }

        public override void DirencOlcumu()
        {
            Console.WriteLine("Analog avometre ile direnç ölçümü");
        }
    }
}
