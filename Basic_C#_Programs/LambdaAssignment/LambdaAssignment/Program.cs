using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main()
        {
            List<Employee> Employees = new List<Employee>()
            {
               new Employee() {Id = 1, firstName = "Joe", lastName = "Plumber" },
               new Employee() {Id = 2, firstName = "Joe", lastName = "Richardson" },
               new Employee() {Id = 3, firstName = "Brandon", lastName = "Chang" },
               new Employee() {Id = 4, firstName = "Lisa", lastName = "Tarbuck" },
               new Employee() {Id = 5, firstName = "Gene", lastName = "Simmons" },
               new Employee() {Id = 6, firstName = "Tiffany", lastName = "Pancakes" },
               new Employee() {Id = 7, firstName = "Bill", lastName = "Williamson" },
               new Employee() {Id = 8, firstName = "Jane", lastName = "Doe" },
               new Employee() {Id = 9, firstName = "Bob", lastName = "Opedic" },
               new Employee() {Id = 10, firstName = "Nicki", lastName = "Minaj" },
            };

            List<Employee> joePloyee = new List<Employee>();
            

            // For Each Joe List
            foreach (Employee employee in Employees)
            {

                if (employee.firstName == "Joe")
                {
                    joePloyee.Add(employee);
                }
                Console.WriteLine(employee.firstName + " " + employee.lastName + ", " + employee.Id);
            }

            // Lambda Joe List
            List<Employee> joePloyee2 = Employees.Where(j => j.firstName == "Joe").ToList();
            Console.WriteLine(joePloyee2.Count);

            // Lambda Id Check
            List<Employee> fivePlus = Employees.Where(s => s.Id > 5).ToList();
            Console.WriteLine(fivePlus.Count);

            Console.ReadLine();
        }
    }
}
