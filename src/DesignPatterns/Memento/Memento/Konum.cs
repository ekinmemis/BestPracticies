using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Konum
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Konum()
        {
            X = 0;
            Y = 0;
        }

        public Konum(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("X: {0} - Y: {1}", X, Y);
        }
    }
}
