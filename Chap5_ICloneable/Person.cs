using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_ICloneable
{
    class Person:ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Manager { get; set; }

        public object Clone()
        {
            Person person = new Person();
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.Manager = Manager;
            return person;
        }
    }
}
