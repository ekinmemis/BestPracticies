using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class ElemanBilgileri
    {
        public ElemanTurleri Tur { get; set; }
        public string Detay { get; set; }
        public Konum Konum { get; set; }

        public ElemanBilgileri()
        {

        }

        public ElemanBilgileri(string detay,Konum konum, ElemanTurleri tur)
        {
            Detay = detay;
            Konum = konum;
            Tur = tur;
        }
    }
}
