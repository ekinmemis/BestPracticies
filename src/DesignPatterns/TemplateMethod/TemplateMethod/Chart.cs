using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class Chart : ReportHelper
    {
        public override void Render()
        {
            Console.WriteLine("Graif sunum");
        }
    }
}
