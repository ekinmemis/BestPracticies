using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class Operator
    {

        public Operator(string isim)
        {
            _isim = isim;
        }

        private bool _durum;
        public bool Durum
        {
            get
            {
                return _durum;
            }
            set
            {
                _durum = value;
            }
        }

        private string _isim;
        public string Isim
        {
            get
            {
                return _isim;
            }
            set
            {
                _isim = value;
            }
        }

        private Operator _sonrakiOperator;
        public Operator SonrakiOperator
        {
            get
            {
                return _sonrakiOperator;
            }
            set
            {
                _sonrakiOperator = value;
            }
        }

        public void CagriCevapla()
        {
            if (_durum)
                //cevapla
                Console.WriteLine(_isim + " çağrıyı cevapladı");
            else if (_sonrakiOperator != null)
                _sonrakiOperator.CagriCevapla();
            else
                Console.WriteLine("çağrı beklemede");
        }

    }
}
