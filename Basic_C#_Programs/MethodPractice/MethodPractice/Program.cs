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

           

            Console.WriteLine("Pick a number to do math operations with.");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number to do math operations with.");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstNum + " plus " + secondNum + " equals " + MathMethods.MyAdd(firstNum, secondNum));
            Console.WriteLine(firstNum + " minus " + secondNum + " equals " + MathMethods.MySub(firstNum, secondNum));
            Console.WriteLine(firstNum + " multiplied by " + secondNum + " equals " + MathMethods.MyMult(firstNum, secondNum));
            

            Console.ReadLine();
        }
        
    }
}
