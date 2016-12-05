using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace playwithcode
{
    public class Point2D
    {
        protected int x, y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double dist2D(Point2D p)
        {
            return Math.Sqrt(Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2));
        }

        public virtual void printDistance(double d)
        {
            Console.WriteLine(String.Format("2D distance = {0}", Math.Ceiling(d)));
        }
    }
}
