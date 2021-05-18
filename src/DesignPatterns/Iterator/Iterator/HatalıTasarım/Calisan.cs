namespace Iterator.HatalıTasarım
{
    class Calisan
    {
        public Calisan(string kimlik, string unvan)
        {
            Kimlik = kimlik;
            unvan = Unvan;
        }

        public string Kimlik { get; set; }
        public string Unvan { get; set; }

        public override string ToString()
        {
            return Kimlik + " " + Unvan;
        }
    }
}
