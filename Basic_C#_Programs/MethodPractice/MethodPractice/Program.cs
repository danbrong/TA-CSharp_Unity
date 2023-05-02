using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    public class Program
    {
        static void Main()
        {
            MathMethods addMethod = new MathMethods();
            MathMethods subMethod = new MathMethods();
            MathMethods multMethod = new MathMethods();

            // If an instructor is reading this, when would I need the above code, and when can I skip it?



            Console.WriteLine("Pick a number to do math operations with.");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine(firstNum + " plus 2, equals " + addMethod.MyAdd(firstNum));
            Console.WriteLine(firstNum + " minus 2, equals " + subMethod.MySub(firstNum));
            Console.WriteLine(firstNum + " multiplied by 2, equals "  + multMethod.MyMult(firstNum));
            

            Console.ReadLine();
        }
        
    }
}
