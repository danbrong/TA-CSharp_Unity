using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Sopranos = { "Tony", "Carmella", "Meadow", "Anthony Jr.", "Junior", };
            Console.WriteLine("Choose an index position between 0 and 4.");
            int choice1 = Convert.ToInt32(Console.ReadLine());


            if (choice1 >= 0 && choice1 <= 4)
            {
                Console.WriteLine("You've chosen: " + Sopranos[choice1]);
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have chosen an incorrect index, we'll move on.");
            }

            int[] Prime = { 1, 2, 3, 5, 7, 11, 13 };
            Console.WriteLine("Choose an index position between 0 and 6.");
            int choice2 = Convert.ToInt32(Console.ReadLine());

            if (choice2 >= 0 && choice2 <= 6)
            {
                Console.WriteLine("You've chosen: " + Prime[choice2]);
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have chosen an incorrect index, we'll move on.");
            }

            List<string> stringList = new List<string>();
            stringList.Add("Index 0");
            stringList.Add("Index 1");
            stringList.Add("Index 2");
            stringList.Add("Index 3");
            stringList.Add("Index 4");

            Console.WriteLine("Choose an index position between 0 and 4.");
            int choice3 = Convert.ToInt32(Console.ReadLine());

            if (choice3 >= 0 && choice3 <= 4)
            {
                Console.WriteLine("You've chosen: " + stringList[choice3]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have chosen an incorrect index, we're closing this program next time you press \"Enter\"");
                Console.ReadLine();
            }
        }
    }
}
