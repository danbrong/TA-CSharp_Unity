using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Void_Method myObj = new Void_Method();

            myObj.MyOp(2, 3);
            myObj.MyOp(x: 6, y: 7);

            Console.ReadLine();
        }
    }
}
