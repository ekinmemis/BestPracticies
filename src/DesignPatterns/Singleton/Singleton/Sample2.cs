namespace Singleton
{
    public class Sample2
    {
        //Nesnenin yalnızca referans alınan sınıflar tarafından yaratılabilmesine izin verilmesi.
        protected Sample2()
        {
            //Varsayılan Yapıcı
        }

        public int Value { get; set; }

        ////Nesnenin oluşturulması engellendi
        //private Sample2()
        //{
        //    //Varsayılan yapıcı
        //}

        //Farklı threadlerden Sample2 nesnenin yaratılışının önüne geçilmesi için lock anahtar kelimesi kullanılır.
        private static object locked_obj = new object();

        private static Sample2 _sample2;

        public static Sample2 CreateObject()
        {
            lock (locked_obj)
                if (_sample2 == null)
                    _sample2 = new Sample2();

            return _sample2;
        }


    }
}
