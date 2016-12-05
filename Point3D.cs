using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace playwithcode
{
    public class Point3D : Point2D
    {
        private int z;

        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public double dist3D(Point3D p)
        {
            return Math.Sqrt(Math.Pow(dist2D(new Point2D(p.x, p.y)), 2) + Math.Pow(this.z - p.z, 2));
        }

        public override void printDistance(double d)
        {
            Console.WriteLine(String.Format("3D distance = {0}", Math.Ceiling(d)));
        }
    }
}
