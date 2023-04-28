using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>() { 36, 42, 12, 18, 60 };

            try
            {
            Console.WriteLine("Choose a number to divide our list by. ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            
                foreach (int number in Numbers)
                {
                    int quotient = number / divisor;
                    Console.WriteLine(quotient);
                }
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please use only integers.");
                return;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by 0.");
                return;
            }
            finally
            {
                Console.ReadLine();
            }
        }
                
        }
    }
