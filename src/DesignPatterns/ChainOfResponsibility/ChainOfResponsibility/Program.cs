using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //İstemci öperatörleri tanımamaktadır
            //öperatörlerde istemciyi tanımamaktadır
            Istemci.CagriAc(new CallCenter());
        }
    }
}
