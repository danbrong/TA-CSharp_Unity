using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class MethodClass
    {
        public static int MyOp(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public static int MyDec(double x, double y)
        {
            int diff = Convert.ToInt32(x - y);
            return diff;
        }

        public static int MyConvert(string x, string y)
        {
            int conX = Convert.ToInt32(x);
            int conY = Convert.ToInt32(y);
            int convert = conX + conY;
            return convert;
        }

    }
}
