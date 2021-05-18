using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Stok : IObservable
    {
        private int _adet;
        private List<Kontrol> kontroller;
        public Stok()
        {
            kontroller = new List<Kontrol>();
            _adet = 10;
        }

        public void ElemanCek()
        {
            --_adet;
        }

        public void Notify()
        {
            for (int i = 0; i < kontroller.Count - 1; i++)
                kontroller[i].onAction(_adet.ToString());
        }

        public void Register(Kontrol k)
        {
            kontroller.Add(k);
        }

        public void UnRegister(Kontrol k)
        {
            kontroller.Remove(k);

        }


    }
}
