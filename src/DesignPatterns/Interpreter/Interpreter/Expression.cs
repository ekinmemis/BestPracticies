using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    abstract class Expression
    {

        public abstract void Interpreter(Direnc context);
        protected RenkKodu[] renkler;
        protected RenkKodu[] carpanlar;
        protected RenkKodu[] toleranslar;

        public Expression()
        {
            renkler = new RenkKodu[10]
            {
                new RenkKodu("0","siyah"),
                new RenkKodu("1","kahve"),
                new RenkKodu("2","kırmızı"),
                new RenkKodu("3","turuncu"),
                new RenkKodu("4","sarı"),
                new RenkKodu("5","yeşil"),
                new RenkKodu("6","mavi"),
                new RenkKodu("7","mor"),
                new RenkKodu("8","gri"),
                new RenkKodu("9","beyaz"),
            };

            carpanlar = new RenkKodu[10]
            {
                new RenkKodu("1","siyah"),
                new RenkKodu("10","kahve"),
                new RenkKodu("100","kırmızı"),
                new RenkKodu("1000","turuncu"),
                new RenkKodu("10000","sarı"),
                new RenkKodu("100000","yeşil"),
                new RenkKodu("1000000","mavi"),
                new RenkKodu("10000000","mor"),
                new RenkKodu("100000000","gri"),
                new RenkKodu("1000000000","beyaz"),
            };

            toleranslar = new RenkKodu[3]
            {
                new RenkKodu("5","altın"),
                new RenkKodu("10","gümüş"),
                new RenkKodu("20","renksiz")
            };
        }
    }
}
