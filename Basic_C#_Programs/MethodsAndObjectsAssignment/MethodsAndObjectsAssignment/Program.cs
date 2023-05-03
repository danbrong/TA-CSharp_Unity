using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 4332;
            employee.Things = new List<string>() { "String 1 ", "String 2", "String 3", "String 4" };

            Employee<string> employee2 = new Employee<string>();
            employee2.FirstName = "Example";
            employee2.LastName = "Scholar";
            employee2.Id = 4332;

            Employee<int> employee3 = new Employee<int>();
            employee3.Things = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (var thing in employee3.Things)
            {
                Console.WriteLine(thing);
            }


            employee.SayName();
            employee2.SayName();

            Console.WriteLine(employee.Id == employee2.Id);
            Console.ReadLine();

        }
    }
}
