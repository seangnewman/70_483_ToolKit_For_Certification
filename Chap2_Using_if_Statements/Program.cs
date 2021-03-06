﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2_Using_if_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare some variables for use in the code and assign initial values
            int first = 2;
            int second = 0;

            // Use a single if sttement to evaluate a condition and output
            // some text
            // indicating the result

            Console.WriteLine("Single if statement");

            if(first == 2)
            {
                Console.WriteLine("The if statement evaluated to true");
            }
            Console.WriteLine("This line outputs regardless of the if condition");

            Console.WriteLine();

            // create an if statement that evaluates two conditions and executes
            // statements only if both are true
            Console.WriteLine("An if statement using && operator");

            if( first == 2 && second == 0)
            {
                Console.WriteLine("The if statement evaluated to true");
            }

            Console.WriteLine("This line outputs regardles of the if condition");

            Console.WriteLine();

            // Create nested if statements
            Console.WriteLine("Nested if statements");

            if(first == 2)
            {
                if(second == 0)
                {
                    Console.WriteLine("Both outer and inner conditions are true");
                }
                Console.WriteLine("Outer condition is true, inner may be true");
            }
            Console.WriteLine("This line outputs regardless of the if condition");
            Console.WriteLine();

            Console.ReadKey();
        }

       
    }
}
