using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor1
{
    class KurumsalMüsteri : Müsteri
    {
        public string Firma { get; protected set; }
        public KurumsalMüsteri(string adi, string soyadi, string firma)
            : base(adi, soyadi)
        {
            Firma = firma;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
