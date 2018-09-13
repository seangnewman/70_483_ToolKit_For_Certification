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


            Student myStudent = new Student("Tom", "Thumb");
            myStudent.MiddleInitial = 'R';
            myStudent.Age = 15;
            myStudent.GPA = 3.5;
            myStudent.displayDetails();


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
