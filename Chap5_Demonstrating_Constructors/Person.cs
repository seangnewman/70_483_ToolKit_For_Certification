using System;

namespace Chap5_Demonstrating_Constructors
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

         

        public Person(string firstName)
        {
            Form1.Results += String.Format(" Person({0}){1} ", firstName, Environment.NewLine);

            FirstName = firstName;
        }

        // constructor with first and last name
        public Person(string firstName, string lastName) : this(firstName) 
        {
            Form1.Results += String.Format(" Person({0},{1}){2} ", firstName, lastName, Environment.NewLine);
            LastName = lastName;
        }
    }
}