using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Employee employee1 = new Employee();

             

            if(employee1 is Employee)
            {
                Employee emp = (Employee)employee1;
            }

            Employee emp2 = employee1 as Employee;
            if(emp2 != null)
            {
                // do something
            }
        }
    }
}
