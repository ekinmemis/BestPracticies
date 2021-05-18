namespace Singleton
{
    public class Sample3
    {
        public int Value { get; set; }

        //Birden fazla işlemcinin olduğu veya çok çekirdekli sistemlerde singleton paternini garantilemek için volatile kelime kullanılır.
        private static volatile Sample3 _sample3;

        private static object locked_object = new object();
        
        private Sample3()
        {
        }

        public static Sample3 CreateObject()
        {
            lock (locked_object)
                if (_sample3 == null)
                    _sample3 = new Sample3();

            return _sample3;
        }



    }
}
