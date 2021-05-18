using Iterator.Idomlar;
using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {

            #region HatalıTasarım/AntiPatern

            //IKDepartmani ik = new IKDepartmani();
            //Calisan[] calisanlar = ik.GetCalisanlar();
            //foreach (var item in calisanlar)
            //    Console.WriteLine(item.ToString());

            //ADKDepartmani adk = new ADKDepartmani();
            //List<Calisan> calisanlar1 = adk.GetCalisanlar();
            //foreach (var item in calisanlar1)
            //    Console.WriteLine(item.ToString()); 

            #endregion

            #region Olması gereken tasarım

            IkDepartmani ik = new IkDepartmani();
            Iterator itr = ik.GetIterator();

            while (itr.Next())
                Console.WriteLine(itr.GetItem().ToString());

            Console.WriteLine("--------");

            AdkDepartmani adk = new AdkDepartmani();
            Iterator itr1 = adk.GetIterator();

            while (itr1.Next())
                Console.WriteLine(itr1.GetItem().ToString());

            #endregion


        }
    }
}
