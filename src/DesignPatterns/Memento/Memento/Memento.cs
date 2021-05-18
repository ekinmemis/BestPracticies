using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Memento
    {
        public ElemanBilgileri ElemanBilgileri { get; set; }

        public Memento(ElemanBilgileri elemanBilgileri)
        {
            ElemanBilgileri = elemanBilgileri;
        }
    }
}
