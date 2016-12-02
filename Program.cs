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
            var program = new BigSum();
            // var program = new DiagonalDifference();
            // var program = new PlusMinus();
            // var program = new StairCase();
            // var program = new TimeConversion();
            // var program = new CircularArrayRotation();

            program.RunProgram();
        }
    }
}
