using System;

namespace Observer
{
    class Program
    {
        static void Display(Kontrol k) => Console.WriteLine(k.Name + " " + k.Text);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
           
            #region Patern

            Kontrol k1 = new Label();
            k1.Name = "text1";
            Kontrol k2 = new Label();
            k2.Name = "text2";

            Stok stok = new Stok();
            stok.Register(k1);
            stok.Register(k2);

            stok.Notify();
            Display(k1);
            Display(k2);

            stok.ElemanCek();
            stok.Notify();
            Display(k1);
            Display(k2);

            stok.ElemanCek();
            stok.Notify();
            Display(k1);
            Display(k2);

            #endregion

            #region Idom



            #endregion
        }
    }
}
