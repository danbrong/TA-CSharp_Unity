using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class VoidMethod
    {
        public void MyDivide(int x)
        {
            int quotient = x / 2;
            Console.WriteLine(quotient);
        }

        public void MyDivide(int y, int z)
        {
            int quotient2 = (y + z)/2;
            Console.WriteLine(quotient2);
        }
        public void MyOutput(out int x)
        {
            int output = 3;
            x = output;
            Console.WriteLine(output);
        }

        public static void MyStatic()
        {
            string Static = "Static Statement";
            Console.WriteLine(Static);
        }
    }
}
