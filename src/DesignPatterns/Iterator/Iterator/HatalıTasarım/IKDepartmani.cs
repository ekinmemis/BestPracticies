namespace Iterator.HatalıTasarım
{
    class IKDepartmani
    {
        private Calisan[] calisanlar;

        public IKDepartmani()
        {
            calisanlar = new Calisan[3];

            calisanlar[0] = new Calisan("Ekin", "Mid-Senior Developer");
            calisanlar[1] = new Calisan("Muhammed", "Senior Software Developer");
            calisanlar[2] = new Calisan("Tugay", "Senior Software Developer");
        }

        public Calisan[] GetCalisanlar()
        {
            return calisanlar;
        }


    }
}
