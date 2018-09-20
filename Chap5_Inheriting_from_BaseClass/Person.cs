using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_Inheriting_from_BaseClass
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            if((firstName == null) || (firstName.Length < 1)){
                throw new ArgumentOutOfRangeException(
                    "firstName", firstName, "FirstName must not be null or blank");
            }
            if ((lastName == null) || (lastName.Length < 1))
            {
                throw new ArgumentOutOfRangeException(
                    "lastName", lastName, "LastName must not be null or blank");
            }

            // Save the first and last names
            FirstName = firstName;
            LastName = lastName;

        }
    }
}
