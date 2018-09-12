using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class_with_methods
{
    class Student
    {
        public static int StudentCount;
        public string firstName;
        public string lastName;
        public string grade;

        public Student(string firstName, string lastName, string grade)
        {
            StudentCount++;
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }

        public string concatenateName()
        {
            return String.Format("{0} {1}", firstName, lastName);
        }

        public void displayName()
        {
            Console.WriteLine(concatenateName()); 
        }
    }
}
