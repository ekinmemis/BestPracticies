using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Sample2
{
    class Araba
    {
        protected List<string> _zorunluParcalar;
        public List<string> OpsiyonelParcalar { get; set; }

        public Araba()
        {
            _zorunluParcalar = new List<string>();
            _zorunluParcalar.AddRange(new string[] { "Rotil", "Salıncak", "Egzantrik Mili", "Krank Mili", "Yağ Pompası", "Radyatör", "Buji", "Tekerlek", "Egzost" });
            OpsiyonelParcalar = new List<string>();
        }
    }
}
