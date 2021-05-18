using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe
{
    class CStok : INotifyPropertyChanged
    {
        private int _adet;
        public int Adet
        {
            get => _adet;
            set
            {
                _adet = value;
                OnChanged("Adet");
            }
        }

        private string _urun;
        public string Urun
        {
            get => _urun; 
            set
            {
                _urun = value;
                OnChanged("Urun");
            }
        }

        public CStok(string urun,int adet)
        {
            _adet = adet;
            _urun = urun;
        }


        protected void OnChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
