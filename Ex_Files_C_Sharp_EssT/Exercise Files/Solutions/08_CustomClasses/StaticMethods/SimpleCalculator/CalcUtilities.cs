using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class CalcUtilities
    {
        public static double Add(double double1, double double2)
        {
            return double1 + double2;
        }

        public static double Subtract(double double1, double double2)
        {
            return double1 - double2;
        }

        public static double Multiply(double double1, double double2)
        {
            return double1 * double2;
        }

        public static double Divide(double double1, double double2)
        {
            if (double1 == 0 || double2 == 0)
            {
                return 0;
            }
            else
            {
                return double1 / double2;
            }
        }

    }
}
