using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4_Casting_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare and initialize an array of Employees
            Employee[] employees = new Employee[10];

            for (int id = 0; id < employees.Length; id++)
            {
                employees[id] = new Employee();
            }

            // Let's do an implicit cast to array of Persons
            Person[] persons = employees;

            //Explicit cast back to array of Employees
            employees = (Employee[])persons;

            if(persons is Employee[])
            {
                // Do Something
            }

            // Using the as operator
            employees = persons as Employee[];

            // After this as statement, manager is null
            Manager[] managers = persons as Manager[];

            if(persons is Manager[]) { 
                // Do Something
            }

        }
    }
}
