using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number, it will be multiplied by 50.");
            string myNum = Console.ReadLine();
            double Num = Convert.ToDouble(myNum);
            double product = Num * 50;
            Console.WriteLine(product);

            Console.WriteLine("Pick another number, we will add 25 to it.");
            string myNum2 = Console.ReadLine();
            int Num2 = Convert.ToInt32(myNum2);
            int sum = Num2 + 25;
            Console.WriteLine(sum);

            Console.WriteLine("Pick another number, we will divide it by 12.5.");
            string myNum3 = Console.ReadLine();
            double Num3 = Convert.ToDouble(myNum3);
            double quotient = Num3 / 12.5;
            Console.WriteLine(quotient);

            Console.WriteLine("Pick a number, we will check if it is greater than 50.");
            string myNum4 = Console.ReadLine();
            int Num4 = Convert.ToInt32(myNum4);
            bool greaterThan = Num4 > 50;
            Console.WriteLine(greaterThan);

            Console.WriteLine("Pick a number, we will divide by 7 and find the remainder.");
            string myNum5 = Console.ReadLine();
            double Num5 = Convert.ToDouble(myNum5);
            double remainder = Num5 % 7;
            Console.WriteLine(remainder);


            Console.ReadLine();
        }
    }
}
