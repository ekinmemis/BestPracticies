using System;

namespace Visitor1
{
    class Program
    {
        static void Main(string[] args)
        {
            BireyselMüsteri bireyselMüsteri = new BireyselMüsteri("ekin", "memiş");
            KurumsalMüsteri kurumsalMüsteri = new KurumsalMüsteri("muhammed", "yılmaz", "defacto");
            
            KrediKullanimi.Leasing(bireyselMüsteri);
            KrediKullanimi.Leasing(kurumsalMüsteri);
            KrediKullanimi.Mortgage(bireyselMüsteri);
            KrediKullanimi.Mortgage(kurumsalMüsteri);
        }
    }
}
