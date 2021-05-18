namespace Singleton
{
    public class Sample1
    {
        //Nesnenin yalnızca referans alınan sınıflar tarafından yaratılabilmesine izin verilmesi.
        protected Sample1()
        {
            //Varsayılan Yapıcı
        }

        public int Value { get; set; }
        
        public static Sample1 _sample1;

        public static Sample1 CreateObject()
        {
            if (_sample1 == null)
                _sample1 = new Sample1();

            return _sample1;
        }

        //Yazılımcı method veya property olarak kullanmak isteyebilir. 2 yöntemde aynı işlemi ifade etmektedir.
        public static Sample1 GetObject
        {
            get
            {
                if (_sample1 == null)
                    _sample1 = new Sample1();

                return _sample1;
            }
        }
    }
}
