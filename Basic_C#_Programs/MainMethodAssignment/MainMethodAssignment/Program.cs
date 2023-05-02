using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodClass addition = new MethodClass();
            MethodClass difference = new MethodClass();

            Console.WriteLine(MethodClass.MyOp(2, 2));

            Console.WriteLine(MethodClass.MyDec(3.14, 2.12));

            Console.WriteLine(MethodClass.MyConvert("3", "4"));
            Console.ReadLine();
        }
    }
}
