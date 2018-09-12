using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_using_properties
{
    class Student
    {

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private char middleInitial;

        public char MiddleInitial
        {
            get { return middleInitial; }
            set { middleInitial = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 6)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Student age must be greater than 6");
                }
            }
        }

        private string program;

        public string Program
        {
            get { return program; }
            set {  }
        }

        private double gpa;

        public double GPA
        {
            get { return gpa; }
            set {
                 if(value <= 4.0)
                {
                    gpa = value;
                }
                else
                {
                    Console.WriteLine("GPA cannot exceed 4.0");
                }

             }
        }

        public void displayDetails()
        {
            Console.WriteLine("{0} {1} {2}  has a GPA of {3}", this.FirstName, this.MiddleInitial, this.LastName, this.GPA);
        }







    }
}
