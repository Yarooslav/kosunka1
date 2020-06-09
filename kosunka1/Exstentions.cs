using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosunka1
{
    public static class Exstentions
    {
        public static Point Plus(this Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p2.Y + p1.Y);
        }
    }
}
