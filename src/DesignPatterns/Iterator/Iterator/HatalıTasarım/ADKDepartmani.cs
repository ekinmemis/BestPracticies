using System.Collections.Generic;

namespace Iterator.HatalıTasarım
{
    class ADKDepartmani
    {
        private List<Calisan> calisanlar;
        public ADKDepartmani()
        {
            calisanlar = new List<Calisan>()
            {
                new Calisan("Tarkan","Senior Software Developer"),
                new Calisan("Bayram","Ceo"),
                new Calisan("Tayfun","Grafiker")
            };
        }

        public List<Calisan> GetCalisanlar()
        {
            return calisanlar;
        }
    }
}
