using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Brush brush1 = new SolidBrush();
            Brush brush2 = new LinearGrandientBrush();
            Brush brush3 = new RadialGradientBrush();

            Rectangle rectangle = new Rectangle(brush1);
            rectangle.Draw();

        }
    }
}
