using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class SolidBrush : Brush
    {
        public override void Paint()
        {
            Console.WriteLine("Tek renkli boyama");
        }
    }
}
