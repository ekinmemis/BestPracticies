using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Sample2
{
    class Acenta
    {
        private Fabrika _fabrika;
        public Bmw BmwTalebi(string model,params string[] parcalar)
        {
            _fabrika = new BMWFabrika();
            
            foreach (var parca in parcalar)
                _fabrika.ParcaEkle(parca);

            return (Bmw)_fabrika.Uret(model);
        }

        public Audi AudiTalebi(string model, params string[] parcalar)
        {
            _fabrika = new BMWFabrika();

            foreach (var parca in parcalar)
                _fabrika.ParcaEkle(parca);

            return (Audi)_fabrika.Uret(model);
        }
    }
}
