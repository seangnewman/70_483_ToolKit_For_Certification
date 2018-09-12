using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_overloading_constructors
{
    class Student
    {
        public string firstName;
        public string lastName;
        public int grade;
        public string schoolName;

        public Student()
        {

        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

        }

        public Student(string firstName, string lastName, string schoolName, int grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.schoolName = schoolName;
            this.grade = grade;
        }
    }
}
