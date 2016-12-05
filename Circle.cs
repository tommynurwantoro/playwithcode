using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace playwithcode
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return Math.Ceiling(Math.PI * radius * radius);
        }
    }

    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double getArea()
        {
            return Math.Ceiling(width * height);
        }
    }

    public class Square
    {
        private double width;

        public Square(double width)
        {
            this.width = width;
        }

        public double getArea()
        {
            return Math.Ceiling(width * width);
        }
    }
}
