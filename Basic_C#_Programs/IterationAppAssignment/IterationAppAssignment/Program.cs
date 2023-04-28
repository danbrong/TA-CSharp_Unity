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
                Console.WriteLine(Slayers[i] + choice1 + "s.");
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


            // List of Strings, Unique
            List<string> Sopranos = new List<string>() { "Tony", "Carmella", "Meadow", "Anthony", "Junior" };

            Console.WriteLine("Who is your favorite Soprano Family Member? ");
            string choice2 = Console.ReadLine();

            int index = Sopranos.IndexOf(choice2);
            switch (index)
            {
                case 0:
                    Console.WriteLine("0");
                    break;
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                default:
                    Console.WriteLine("Sorry, I don't recognize that Soprano.");
                    break;
            }


            // List of Strings, two identical (DON"T KNOW HOW TO SHOW SECOND CAT INDEX)
            List<string> Animals = new List<string>() { "Cat", "Dog", "Chicken", "Turtle", "Cat" };

            Console.WriteLine("Type in one of the following; Cat, Dog, Chicken, or Turtle, to find its index.");
            string pet = Console.ReadLine();
            

            if (!Animals.Contains(pet))
            {
                Console.WriteLine("Sorry, I don't recognize that animal.");
            }

            for (int animalIndex = Animals.IndexOf(pet); animalIndex < Animals.Count; animalIndex++)
            {
                if (Animals.Contains(pet))
                {
                    Console.WriteLine(Animals.IndexOf(pet));
                }
            }
            // ABOVE SECTION NEEDS REVISION


            // List of Strings, two identical plus forloop
            List<string> birdPrey = new List<string>() { "Harley", "Huntress", "Canary", "Renee", "Cass", "Harley" };

            

            foreach (string bird in birdPrey)
            {
                    if (bird == bird)
                    {
                        Console.WriteLine(bird + ": This bird has shown up once before!");
                    }
                    else
                    {
                        Console.WriteLine(bird + ": This bird is new!");
                    }
            }
            // ABOVE SECTION NEEDS REVISIONS, UNSURE HOW TO PROCEED ON PARTS 5 AND 6
            
            Console.ReadLine();
        }
    }
}
