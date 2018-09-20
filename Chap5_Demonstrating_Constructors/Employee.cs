using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_Demonstrating_Constructors
{
    public class Employee:Person
    {
        public string DepartmentName { get; set; }

        public Employee(string firstName):base(firstName)
        {
            Form1.Results += String.Format(" Employee({0}){1} ", firstName, Environment.NewLine);
        }

        // constructor with first and last name
        public Employee(string firstName, string lastName):base(firstName, lastName)
        {
            Form1.Results += String.Format(" Person({0},{1}){1} ", firstName, lastName, Environment.NewLine);
        }

        // constructor with first, last and department name
        public Employee(string firstName, string lastName, string deptName):this(firstName, lastName)
        {
            Form1.Results += String.Format(" Person({0},{1},{2}){3} ", firstName, lastName, deptName, Environment.NewLine);
        }
    }
}
