using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor1
{
    class MortgageVisitor : IVisitor
    {
        public void Visit(Müsteri müsteri)
        {
            if (müsteri is BireyselMüsteri)
                Console.WriteLine("Bireysel müşteri mortgage yapabilir");
            if (müsteri is KurumsalMüsteri)
                Console.WriteLine("Kurumsal müşteri mortgage yapamaz");
        }
    }
}
