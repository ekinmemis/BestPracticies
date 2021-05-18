using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            ElemanBilgileri eb = new ElemanBilgileri();
            eb.Tur = ElemanTurleri.Transitor;
            eb.Konum = new Konum(12, 35);
            eb.Detay = "BC-237";

            Eleman originator = new Eleman(eb);
            Console.WriteLine(originator.ToString());
            
            Memento memento = originator.CreateMemento();
            originator.ElemanBilgileri = new ElemanBilgileri("BD-547", new Konum(12, 35), ElemanTurleri.Transitor);
            originator.SetMemento(memento);

            Console.WriteLine(originator.ToString());
        }
    }
}
