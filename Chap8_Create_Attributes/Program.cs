using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_Create_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myTestClassType = typeof(MyTestClass);

            MyCustomAttribute attribute = (MyCustomAttribute)myTestClassType.GetCustomAttribute(typeof(MyCustomAttribute), false);

            Debug.WriteLine(string.Format("Property1: {0}", attribute.Property1));
            Debug.WriteLine(string.Format("Property2: {0}", attribute.Property2));
            Debug.WriteLine(string.Format("Property3: {0}", attribute.Property3));
        }
    }
}
