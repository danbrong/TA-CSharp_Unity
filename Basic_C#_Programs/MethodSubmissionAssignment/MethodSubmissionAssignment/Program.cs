using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Methods optional = new Methods();


            Console.WriteLine("Enter your first number.");
            string stringX = (Console.ReadLine());
            int x = Convert.ToInt32(stringX);

            Console.WriteLine("Enter a second number, or just press Enter.");
            string stringY = (Console.ReadLine());
            int y = Convert.ToInt32(stringY);

            Console.WriteLine(Methods.Optional(x, y));
            Console.ReadLine();

        }
    }
}
