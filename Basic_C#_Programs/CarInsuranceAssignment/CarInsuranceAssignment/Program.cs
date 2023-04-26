using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string myAge = Console.ReadLine();
            int Age = Convert.ToInt32(myAge);

            Console.WriteLine("Have you ever had a DUI? Please answer true or false");
            string myDUI = Console.ReadLine();
            bool DUI = bool.Parse(myDUI);

            Console.WriteLine("How many speeding tickets do you have? Please answer as a number.");
            string myTickets = Console.ReadLine();
            int Tickets = Convert.ToInt32(myTickets);


            bool qualified = (Age > 15 && DUI == false && Tickets <= 3);
            if (qualified == true)
            {
                Console.WriteLine("You are qualified for insurance!");
            }
            else
            {
                Console.WriteLine("You are not qualified for insurance!");
            }

            //Console.WriteLine("You are over 15: " + ageApp);
            //Console.WriteLine("You have no DUIs: " + Penalty);
            //Console.WriteLine("You have less than 3 tickets: " + Speed);

            //Console.WriteLine(Age);
            //Console.WriteLine(DUI);
            //Console.WriteLine(Tickets);
            Console.ReadLine();
        }
    }
}
