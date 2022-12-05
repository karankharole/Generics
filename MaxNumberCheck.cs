using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Generics
{


    public class MaxNumberCheck
    {
        // integer type
        public static int MaxIntegerNumber(int val1, int val2, int val3)
        {
            if (val1.CompareTo(val2) > 0 && val1.CompareTo(val3) > 0 || val1.CompareTo(val2) >= 0 && val1.CompareTo(val3) > 0 || val1.CompareTo(val2) > 0 && val1.CompareTo(val3) >= 0)
            {
                return val1;
            }
            if (val2.CompareTo(val1) > 0 && val2.CompareTo(val3) > 0 || val2.CompareTo(val1) >= 0 && val2.CompareTo(val3) > 0 || val2.CompareTo(val1) > 0 && val2.CompareTo(val3) >= 0)
            {
                return val2;
            }

            if (val3.CompareTo(val1) > 0 && val3.CompareTo(val1) > 0 || val3.CompareTo(val1) >= 0 && val3.CompareTo(val1) > 0 || val3.CompareTo(val1) > 0 && val3.CompareTo(val1) >= 0)
            {
                return val3;
            }
            return val1;
        }

        // double type
        public static double MaxFloatNumber(double val1, double val2, double val3)
        {
            if (val1.CompareTo(val2) > 0 && val1.CompareTo(val3) > 0 || val1.CompareTo(val2) >= 0 && val1.CompareTo(val3) > 0 || val1.CompareTo(val2) > 0 && val1.CompareTo(val3) >= 0)
            {
                return val1;
            }
            if (val2.CompareTo(val1) > 0 && val2.CompareTo(val3) > 0 || val2.CompareTo(val1) >= 0 && val2.CompareTo(val3) > 0 || val2.CompareTo(val1) > 0 && val2.CompareTo(val3) >= 0)
            {
                return val2;
            }

            if (val3.CompareTo(val1) > 0 && val3.CompareTo(val1) > 0 || val3.CompareTo(val1) >= 0 && val3.CompareTo(val1) > 0 || val3.CompareTo(val1) > 0 && val3.CompareTo(val1) >= 0)
            {
                return val3;
            }
            return val1;
        }

        // char type
        public static string MaxStringNumber(string val1, string val2, string val3)
        {
            if (val1.CompareTo(val2) > 0 && val1.CompareTo(val3) > 0 || val1.CompareTo(val2) >= 0 && val1.CompareTo(val3) > 0 || val1.CompareTo(val2) > 0 && val1.CompareTo(val3) >= 0)
            {
                return val1;
            }
            if (val2.CompareTo(val1) > 0 && val2.CompareTo(val3) > 0 || val2.CompareTo(val1) >= 0 && val2.CompareTo(val3) > 0 || val2.CompareTo(val1) > 0 && val2.CompareTo(val3) >= 0)
            {
                return val2;
            }

            if (val3.CompareTo(val1) > 0 && val3.CompareTo(val1) > 0 || val3.CompareTo(val1) >= 0 && val3.CompareTo(val1) > 0 || val3.CompareTo(val1) > 0 && val3.CompareTo(val1) >= 0)
            {
                return val3;
            }
            return val1;
        }
    }
}
