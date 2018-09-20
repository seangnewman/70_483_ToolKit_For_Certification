using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_Defining_Interface
{
    class Student : Person, IStudent
    {
        public List<string> Courses { get; set; }


        // Implement IStudent.PrintGrades
        // Print th 
        public void PrintGrades()
        {
           // Do whatever is necessary... 
        }
    }
}
