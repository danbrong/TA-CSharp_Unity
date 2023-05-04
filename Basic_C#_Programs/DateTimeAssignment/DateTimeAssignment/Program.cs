using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime assignment = new DateTime();
            assignment = DateTime.Now;
            Console.WriteLine("The time is now " + assignment);
            Console.WriteLine("Give me a number.");
            int mod = Convert.ToInt32(Console.ReadLine());

            DateTime modTime = assignment.AddHours(mod);
            Console.WriteLine(modTime);
            Console.ReadLine();

            

        }
    }
}
