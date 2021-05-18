using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Rectangle
    {
        private Brush _brush;
        public Rectangle(Brush brush)
        {
            _brush = brush;
        }

        public void Draw()
        {
            _brush.Paint();
            Console.WriteLine("Dikdörtgen");
        }
    }
}
