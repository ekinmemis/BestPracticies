using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class RadialGradientBrush : Brush
    {
        public override void Paint()
        {
            Console.WriteLine("2 renkli yuvarlak geçişli boyama");
        }
    }
}
