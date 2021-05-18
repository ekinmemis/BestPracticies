using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class Pivot : ReportHelper
    {
        public override void Render()
        {
            Console.WriteLine("Matris sunum");
        }
    }
}
