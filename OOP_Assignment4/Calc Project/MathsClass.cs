using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Calc_Project
{
    internal class MathsClass
    {
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Subtruct(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            if (y == 0)
                return 0;
            return x / y;

        }
    }
}



