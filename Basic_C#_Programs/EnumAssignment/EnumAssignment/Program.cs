using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        public enum Days
            {
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday,
                Sunday
            }
        static void Main()
        {

            try
            {
                Console.WriteLine("Please enter a day of the week.");
                string choice = Console.ReadLine();
                Days dayChoice = (Days) Enum.Parse(typeof(Days));
                Console.WriteLine(dayChoice);
            }
            catch
            {
                Console.WriteLine("Please enter a valid day of the week.");
            }
            Console.ReadLine();
            
        }
    }
}
