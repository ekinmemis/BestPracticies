using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Eleman
    {
        private ElemanBilgileri _elemanBilgileri;

        public ElemanBilgileri ElemanBilgileri
        {
            set { _elemanBilgileri = value; }
        }

        public Eleman(ElemanBilgileri elemanBilgileri)
        {
            this._elemanBilgileri = elemanBilgileri;
        }


        public Memento CreateMemento()
        {
            return new Memento(_elemanBilgileri);
        }


        public void SetMemento(Memento memento)
        {
            ElemanBilgileri = memento.ElemanBilgileri;
        }

        public override string ToString()
        {
            string str = "Eleman detayları: \n\r";
            str += string.Format("Türü: {0} \n\r Detayı: {1} \n\r Konum: {2}", _elemanBilgileri.Tur, _elemanBilgileri.Konum, _elemanBilgileri.Detay);

            return str;
        }

    }
}
