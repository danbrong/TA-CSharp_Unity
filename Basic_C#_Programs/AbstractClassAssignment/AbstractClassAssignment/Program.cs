using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            IQuittable quitter = new Employee() { firstName = "John", lastName = "Doe" };

            employee.SayName();
            quitter.Quit();
            Console.ReadLine();
        }
    }
}
