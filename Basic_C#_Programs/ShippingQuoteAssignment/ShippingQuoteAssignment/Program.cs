using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instrutions below.");


            Console.WriteLine("What is the weight of the package in kg? Answer only as a number.");
            int Weight = Convert.ToInt32(Console.ReadLine());
            if (Weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the package width in cm? Answer only as a number.");
                int Width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package height in cm? Answer only as a number.");
                int Height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package length in cm? Answer only as a number.");
                int Length = Convert.ToInt32(Console.ReadLine());

                if ((Width + Height + Length) > 50)
                {
                    Console.WriteLine("This package is too big to be shipped.");
                    Console.ReadLine();
                }
                else
                {
                    int quote = (((Weight * Height * Length) * Weight) / 100);
                    Console.WriteLine("Your estimated total for shipping is: $" + quote);
                    Console.ReadLine();
                }
            }
        }
    }
}
