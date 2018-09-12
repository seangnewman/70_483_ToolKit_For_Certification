using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class_with_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student("Joe", "Morgan", "C++");

            newStudent.displayName();
        }
    }
}
