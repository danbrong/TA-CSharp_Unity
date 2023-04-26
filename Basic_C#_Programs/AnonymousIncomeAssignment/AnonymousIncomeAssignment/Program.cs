using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");


            Console.WriteLine("Person 1:");

            Console.WriteLine("What is your Hourly Rate?");
            string myRate = Console.ReadLine();
            float Rate = float.Parse(myRate);

            Console.WriteLine("How many hours do you work a week?");
            string myHours = Console.ReadLine();
            int Hours = Convert.ToInt32(myHours);


            Console.WriteLine("Person 2:");
            Console.WriteLine("What is your Hourly Rate?");
            string myRate2 = Console.ReadLine();
            float Rate2 = float.Parse(myRate2);

            Console.WriteLine("How many hours do you work a week?");
            string myHours2 = Console.ReadLine();
            int Hours2 = Convert.ToInt32(myHours2);


            Console.WriteLine("Person 1: Annual Salary");
            float Salary = Rate * Hours * 52;
            Console.WriteLine(Salary);

            Console.WriteLine("Person 2: Annual Salary");
            float Salary2 = Rate2 * Hours2 * 52;
            Console.WriteLine(Salary2);


            Console.WriteLine("Does Person 1 make more money than person 2?");
            bool myComparison = Salary > Salary2;
            Console.WriteLine(myComparison);


            Console.ReadLine();
        }
    }
}
