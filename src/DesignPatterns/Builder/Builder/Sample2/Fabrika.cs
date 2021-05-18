using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Sample2
{
    abstract class Fabrika
    {
        public abstract void ParcaEkle(string parca);
        public abstract Araba Uret(string model);
    }
}
