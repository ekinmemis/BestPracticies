namespace Builder1
{
    class BMWFabrika:Fabrika
    {
        private Bmw _bmw = new Bmw();
        public override void ParcaEkle(string parca)
        {
            _bmw.OpsiyonelParcalar.Add(parca);
        }

        public override Araba Uret(string model)
        {
            _bmw.Model = model;
            return _bmw;
        }
    }
}
