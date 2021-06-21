using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class CalculatorOperations
    {
        public static double Add(double x, double y)
        {
            if (x + y >= double.MaxValue)
            {
                return double.MaxValue;
            }
            else if (x + y <= double.MinValue)
            {
                return double.MinValue;
            }
            else
            {
                return x + y;
            }
        }

        public static double Subtract(double x, double y)
        {
            if (x - y >= double.MaxValue)
            {
                return double.MaxValue;
            }
            else if (x - y <= double.MinValue)
            {
                return double.MinValue;
            }
            else
            {
                return x - y;
            }
        }

        public static double Multiply(double x, double y)
        {
            if (x * y >= double.MaxValue)
            {
                return double.MaxValue;
            }
            else if (x * y <= double.MinValue)
            {
                return double.MinValue;
            }
            else
            {
                return x * y;
            }
        }

        public static double divide(double x, double y)
        {
            if(y !=0) 
            {
                return x / y;
            }
            else
            {
                return 0; //bussiness logic!
            }
        }
    }
}
