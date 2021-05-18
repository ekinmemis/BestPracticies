namespace Finans
{
    public abstract class Para
    {

        private int _nominalDeger;

        //Virtual Constructor
        protected Para(int nominalDeger)
        {
            _nominalDeger = nominalDeger;
        }

        public string NominalDeger
        {
            get { return _nominalDeger.ToString() + " TL BASILDI!"; }
        }
    }
}
