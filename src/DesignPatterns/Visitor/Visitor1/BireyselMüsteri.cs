using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor1
{
    class BireyselMüsteri : Müsteri
    {
        public BireyselMüsteri(string adi, string soyadi) 
            : base(adi, soyadi)
        {

        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
