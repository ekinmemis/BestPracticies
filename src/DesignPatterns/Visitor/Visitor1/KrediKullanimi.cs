using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor1
{
    class KrediKullanimi
    {
        public static void Mortgage(Müsteri müsteri) => müsteri.Accept(new MortgageVisitor());
        public static void Leasing(Müsteri müsteri) => müsteri.Accept(new LeasingVisitor());
    }
}
