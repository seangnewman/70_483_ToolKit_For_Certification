using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_value_type_passing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 3;
            int result;

            Student firstStudent = new Student();
            firstStudent.firstName = "John";
            firstStudent.lastName = "Smith";
            firstStudent.grade = "six";

            result = sum(num1, num2);
            Console.WriteLine("Sum is ");
            Console.WriteLine(result);                          // output = 5
            Console.WriteLine();

            changeValues(num1, num2);
            Console.WriteLine();
            Console.WriteLine("Back from changeValues()");
            Console.WriteLine(num1);                            // outputs 2
            Console.WriteLine(num2);                            // outputs 3

            Console.WriteLine();
            Console.WriteLine("First name for firstStudent is " + firstStudent.firstName);

            changeName(firstStudent);
            Console.WriteLine();
            Console.WriteLine("First name for firstStudent is " + firstStudent.firstName);





        }

        private static void changeName(Student student)
        {
            Console.WriteLine();
            Console.WriteLine("In changeName()");
            student.firstName = "George";
        }

        private static void changeValues(int num1, int num2)
        {
            Console.WriteLine("In changeValues()");
            Console.WriteLine("value1 is " + num1);                 // outputs 2
            Console.WriteLine("value2 is " + num2);                 // outputs 3
            Console.WriteLine();
            Console.WriteLine("Changing Values");

            num1--;
            num2 += 5;

            Console.WriteLine();
            Console.WriteLine("value1 is now " + num1);             // outputs 1
            Console.WriteLine("value2 is now " + num2);             // outputs 8

        }

        private static int sum(int num1, int num2)
        {
            Console.WriteLine("In method sum()");
            return num1 + num2;
        }
    }
}
