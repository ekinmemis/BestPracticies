using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor1
{
    class LeasingVisitor : IVisitor
    {
        public void Visit(Müsteri müsteri)
        {
            if (müsteri is KurumsalMüsteri)
                Console.WriteLine("Kurumsal müşteri leasing kullanabilir");
            if (müsteri is BireyselMüsteri)
                Console.WriteLine("Bireysel müşteri leasing kullanamaz");
        }
    }
}
