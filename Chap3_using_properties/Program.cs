using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_using_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student();
            newStudent.FirstName = "Larry";
            newStudent.MiddleInitial = 'O';
            newStudent.LastName = "Brian";
            newStudent.Age = 60;
            newStudent.GPA = 3.7;

            newStudent.displayDetails();
        }
    }
}
