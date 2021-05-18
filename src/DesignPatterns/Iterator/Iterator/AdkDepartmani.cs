using System.Collections.Generic;

namespace Iterator
{
    class AdkDepartmani:Iterable
    {
        private List<Calisan> calisanlar;
        public AdkDepartmani()
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

        public Iterator GetIterator()
        {
            return new ListIterator();
        }
    }
}
