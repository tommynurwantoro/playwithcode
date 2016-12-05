using playwithcode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var program = new BigSum();
            // var program = new DiagonalDifference();
            // var program = new PlusMinus();
            // var program = new StairCase();
            // var program = new TimeConversion();
            // var program = new CircularArrayRotation();
            //var program = new MaximumSubArray();

            //program.RunProgram();

            //Circle C1 = new Circle(Convert.ToDouble(Console.ReadLine()));
            //Console.WriteLine(C1.getArea());

            //double[] dimensions = Console.ReadLine().Split().Select(x => Convert.ToDouble(x)).ToArray();
            //Rectangle R1 = new Rectangle(dimensions[0], dimensions[1]);
            //Console.WriteLine(R1.getArea());

            //Circle C2 = new Circle(Convert.ToDouble(Console.ReadLine()));
            //Console.WriteLine(C2.getArea());

            //Square S1 = new Square(Convert.ToDouble(Console.ReadLine()));
            //Console.WriteLine(S1.getArea());

            //dimensions = Console.ReadLine().Split().Select(x => Convert.ToDouble(x)).ToArray();
            //Rectangle R2 = new Rectangle(dimensions[0], dimensions[1]);
            //Console.WriteLine(R2.getArea());

            //Comparator comp = new Comparator();
            //int testCases = Convert.ToInt32(Console.ReadLine());
            //while (testCases-- > 0)
            //{
            //    int condition = Convert.ToInt32(Console.ReadLine());
            //    if (condition == 1)
            //    {
            //        string s1 = Console.ReadLine();
            //        string s2 = Console.ReadLine();
            //        if (comp.compare(s1, s2))
            //        {
            //            Console.WriteLine("Same");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Different");
            //        }
            //    }
            //    else if (condition == 2)
            //    {
            //        int num1 = Convert.ToInt32(Console.ReadLine());
            //        int num2 = Convert.ToInt32(Console.ReadLine());
            //        if (comp.compare(num1, num2))
            //        {
            //            Console.WriteLine("Same");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Different");
            //        }
            //    }
            //    else if (condition == 3)
            //    {
            //        Console.ReadLine();
            //        int[] arr1 = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            //        int[] arr2 = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            //        if (comp.compare(arr1, arr2))
            //        {
            //            Console.WriteLine("Same");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Different");
            //        }
            //    }
            //}

            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());

            Point3D p1 = new Point3D(x1, y1, z1);
            Point3D p2 = new Point3D(x2, y2, z2);
            double d2 = p1.dist2D(p2);
            double d3 = p1.dist3D(p2);
            //The code below uses runtime polymorphism to call the overridden printDistance method:
            Point2D p = new Point2D(0, 0);
            p.printDistance(d2);
            p = p1;
            p1.printDistance(d3);

        }
    }
}
