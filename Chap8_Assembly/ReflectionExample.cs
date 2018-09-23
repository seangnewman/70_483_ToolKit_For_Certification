 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_Assembly
{
    class ReflectionExample
    {

        private string _privateField = "Hello";
        public string _publicField = "Goodbye";
        internal string _internalField = "Hola";
        protected string _protectedField = "Adios";
        static string _staticField = "Bonjour";

        private string privateField = "Studying";

        public string PrivateField
        {
            get { return privateField; }
           
        }

    }
}
