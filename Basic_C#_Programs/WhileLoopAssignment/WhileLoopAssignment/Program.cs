using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The below code is commented out, so that my do-while loop can operate. Uncomment/Comment each block to check regular while loop, and do while loop.

            //// BEGIN WHILE LOOP
            //Console.WriteLine("Guess a number from 1 - 10");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = false;

            //while (!isGuessed)
            //{

            //    switch (number)
            //    {
            //        case 1:
            //            Console.WriteLine("The number you picked was incorrect, try again.");
            //            Console.WriteLine("Guess a number between 1 - 10.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 2:
            //            Console.WriteLine("The number you picked was incorrect, try again.");
            //            Console.WriteLine("Guess a number between 1 - 10.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 3:
            //            Console.WriteLine("The number you picked was incorrect, try again.");
            //            Console.WriteLine("Guess a number between 1 - 10.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 4:
            //            Console.WriteLine("Congratulations, that is correct!");
            //            isGuessed = true;
            //            break;

            //        case 5:
            //            Console.WriteLine("The number you picked was incorrect, try again.");
            //            Console.WriteLine("Guess a number between 1 - 10.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 6:
            //            Console.WriteLine("The number you picked was incorrect, try again.");
            //            Console.WriteLine("Guess a number between 1 - 10.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 7:
            //            Console.WriteLine("The number you picked was incorrect, try again.");
            //            Console.WriteLine("Guess a number between 1 - 10.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 8:
            //            Console.WriteLine("The number you picked was incorrect, try again.");
            //            Console.WriteLine("Guess a number between 1 - 10.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 9:
            //            Console.WriteLine("The number you picked was incorrect, try again.");
            //            Console.WriteLine("Guess a number between 1 - 10.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 10:
            //            Console.WriteLine("The number you picked was incorrect, try again.");
            //            Console.WriteLine("Guess a number between 1 - 10.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        default:
            //            Console.WriteLine("Sorry, I don't recognize that number, try again.");
            //            Console.WriteLine("Guess a number between 1 - 10.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
 

            //Console.ReadLine();
            ////END WHILE LOOP

            // BEGIN DO - WHILE LOOP
            Console.WriteLine("Guess a number from 1 - 10");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 4;

            do
            {

                switch (number)
                {
                    case 1:
                        Console.WriteLine("The number you picked was incorrect, try again.");
                        Console.WriteLine("Guess a number between 1 - 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("The number you picked was incorrect, try again.");
                        Console.WriteLine("Guess a number between 1 - 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("The number you picked was incorrect, try again.");
                        Console.WriteLine("Guess a number between 1 - 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("Congratulations, that is correct!");
                        isGuessed = true;
                        break;

                    case 5:
                        Console.WriteLine("The number you picked was incorrect, try again.");
                        Console.WriteLine("Guess a number between 1 - 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 6:
                        Console.WriteLine("The number you picked was incorrect, try again.");
                        Console.WriteLine("Guess a number between 1 - 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 7:
                        Console.WriteLine("The number you picked was incorrect, try again.");
                        Console.WriteLine("Guess a number between 1 - 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        Console.WriteLine("The number you picked was incorrect, try again.");
                        Console.WriteLine("Guess a number between 1 - 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 9:
                        Console.WriteLine("The number you picked was incorrect, try again.");
                        Console.WriteLine("Guess a number between 1 - 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("The number you picked was incorrect, try again.");
                        Console.WriteLine("Guess a number between 1 - 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Sorry, I don't recognize that number, try again.");
                        Console.WriteLine("Guess a number between 1 - 10.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();
            //END DO - WHILE LOOP
        }
    }
}
