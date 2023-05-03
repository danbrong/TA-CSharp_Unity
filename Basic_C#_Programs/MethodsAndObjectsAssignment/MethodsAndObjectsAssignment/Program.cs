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
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 4332;

            Employee employee2 = new Employee();
            employee2.FirstName = "Example";
            employee2.LastName = "Scholar";
            employee2.Id = 4332;

            employee.SayName();
            employee2.SayName();

            Console.WriteLine(employee.Id == employee2.Id);
            Console.ReadLine();

        }
    }
}
