using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_Defining_Interface
{
    interface IStudent
    {
        // The student's list of current courses
        List<string> Courses { get; set; }

        // Print the student's current grades
        void PrintGrades();
    }
}
