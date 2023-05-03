using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Employee<T> : Person
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }

        public static bool operator ==(Employee<T> employee, Employee<T> employee2)
        {
            if (employee.Id == employee2.Id)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee<T> employee, Employee<T> employee2)
        {
            if (employee.Id != employee2.Id)
                return true;
            else
                return false;
        }
    }
}
