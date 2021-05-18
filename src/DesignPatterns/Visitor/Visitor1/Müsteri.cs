using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor1
{
    abstract class Müsteri
    {
        public string Adi { get; protected set; }
        public string Soyadi { get; protected set; }

        public Müsteri(string adi, string soyadi)
        {
            Adi = adi;
            Soyadi = soyadi;
        }

        public abstract void Accept(IVisitor visitor);
    }
}
