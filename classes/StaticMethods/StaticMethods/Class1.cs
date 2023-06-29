using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    internal class MathFunctions
    {
        public static double SquareRoot(double sValue)
        { 
            return Convert.ToDouble(Math.Sqrt(sValue));
        }

        public static int Sum(int iValue)
        {
            return iValue + iValue;
        }

        public static double Sum(double dValue)
        {
            return Convert.ToDouble(dValue + dValue);
        }

        public static decimal Sum(decimal dValue)
        {
            return Convert.ToDecimal(dValue + dValue);
        }
    }
}
