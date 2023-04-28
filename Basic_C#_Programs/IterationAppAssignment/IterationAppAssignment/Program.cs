using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Slayers = { "Buffy ", "Faith ", "Kendra ", "Pink Hair " };

            // For Loop adding String
            Console.WriteLine("Write a verb here!");
            string choice1 = Console.ReadLine();

            for (int i = 0; i < Slayers.Length; i++)
            {
                Slayers[i] += choice1;
                Console.WriteLine(Slayers[i]);
            }

            Console.WriteLine("\n");

            // For Loop, print each line
            foreach (string s in Slayers)
            {
                Console.WriteLine(s);
            }


            // Infinite Loop, Broken
            //int q = 0;
            //while (q < 4)
            //{
            //    Console.WriteLine(Slayers[q]);
            //}



            // Infinite Loop, Fixed
            int q = 0;
            while (q < 4)
            {
                Console.WriteLine(Slayers[q]);
                q++;
            }


            // Loop with <
            for (int r = 0; r < 4; r++)
            {
                Console.WriteLine(r);
            }

            // Loop with <=
            for (int r = 0; r <= 4; r++)
            {
                Console.WriteLine(r);
            }


            //    // List of Strings, Unique
            List<string> Sopranos = new List<string>() { "Tony", "Carmella", "Meadow", "Anthony", "Junior" };

            Console.WriteLine("Who is your favorite Soprano Family Member? ");
            string choice2 = Console.ReadLine();

            for (int index = Sopranos.IndexOf(choice2); index < Sopranos.Count; index++)
            {
                if (Sopranos.Contains(choice2))
                {
                    Console.WriteLine(Sopranos.IndexOf(choice2));
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, I don't recognize that Soprano.");
                    break;
                }
            }



            // List of Strings, two identical
            List<string> Animals = new List<string>() { "Cat", "Dog", "Chicken", "Turtle", "Cat" };

            Console.WriteLine("Type in one of the following; Cat, Dog, Chicken, or Turtle, to find its index.");
            string pet = Console.ReadLine();


            if (!Animals.Contains(pet))
            {
                Console.WriteLine("Sorry, I don't recognize that animal.");
            }

            for (int a = 0; a < Animals.Count; a++)
            {
                if (Animals[a] == pet)
                {
                    Console.WriteLine(Animals[a] + " index is " + a);
                }
            }
          


            // List of Strings, two identical plus forloop
            List<string> birdPrey1 = new List<string>() { "Harley", "Huntress", "Canary", "Renee", "Cass", "Harley" };
            List<string> birdPrey2 = new List<string>();

            foreach (string name in birdPrey1)
            {
                Console.WriteLine(name);
            }

            foreach (string name2 in birdPrey2)
            {
                Console.WriteLine(name2);
            }


            foreach (string bird in birdPrey1)
            {
                if (!birdPrey2.Contains(bird))
                {
                    birdPrey2.Add(bird);
                    
                }
                else if (birdPrey2.Contains(bird))
                {
                    Console.WriteLine("There is a duplicate entry for " + bird + ".");
                    
                }
                else
                {
                    break;
                    
                }
            }
            Console.ReadLine();
        }
    }
}

