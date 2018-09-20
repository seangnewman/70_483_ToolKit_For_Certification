using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_Defining_Interface
{
    class TeachingAssistant : Faculty, IStudent
    {
        // A Student object to handle IStudent
        private Student MyStudent = new Student();
        
        // Implement IStudent.Courses
        // Student's list of current courses
        public List<string> Courses
        {
            get
            {
                return MyStudent.Courses;
            }
            set
            {
                MyStudent.Courses = value;
            }
        }

        // Implement IStudent.PrintGrades
        public void PrintGrades()
        {
            MyStudent.PrintGrades();
        }
    }
}
