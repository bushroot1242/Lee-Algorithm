using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VizualizationTry
{
    class Dot
    {
        public int X
        {
            get; set;
        }
        public int Y
        {
            get; set;
        }

        public static byte Size
        {
            get { return 5; }
        }
        public static Brush Colore
        {
            get { return Brushes.Blue; }
        }
        public Dot()
        {
            X = 0;
            Y = 0;
        }
        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Dot(Circle c)
        {
            X = c.X;
            Y = c.Y;
        }

        public override string ToString()
        {
            return $"X:{X},Y:{Y}";
        }
    }
}
