using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class LinearGrandientBrush : Brush
    {
        public override void Paint()
        {
            Console.WriteLine("2 renkli çizgisel geçişli boyama");
        }
    }
}
