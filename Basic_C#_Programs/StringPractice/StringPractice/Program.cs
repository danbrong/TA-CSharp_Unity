using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string part1 = "This is the first part, ";
            //string part2 = "this is the second part, ";
            //string part3 = "and this is the third part.";

            //string full = part1 + part2 + part3;
            //Console.WriteLine(full);
            //Console.ReadLine();


            //string lower = "this should be uppercase.";
            //string upper = lower.ToUpper();
            //Console.WriteLine(upper);
            //Console.ReadLine();

         
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("My Name is Brandon");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
