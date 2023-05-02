using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    public class MathMethods
    {
        public static int MyAdd(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public static int MySub(int x, int y)
        {
            int diff = x - y;
            return diff;
        }

        public static int MyMult(int x, int y)
        {
            int prod = x * y;
            return prod;
        }
    }
}
