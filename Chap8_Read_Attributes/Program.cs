using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_Read_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            readAttributes();

        }

        public static void readAttributes()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            AssemblyName[] assemblyNames = assembly.GetReferencedAssemblies();

            foreach (AssemblyName assemblyName in assemblyNames)
            {
                Debug.WriteLine("\nAssembly Name: {0}", assemblyName.FullName);

                Assembly referencedAssembly = Assembly.Load(assemblyName.FullName);

                object[] attributes = referencedAssembly.GetCustomAttributes(false);

                foreach (object attribute in attributes)
                {
                    Debug.WriteLine("\nAttribute Name: {0}", attribute.GetType().Name);

                    // Get the properties of this attribute
                    PropertyInfo[] properties = attribute.GetType().GetProperties();

                    foreach (PropertyInfo property in properties)
                    {
                        Debug.WriteLine("{0} : {1}", property.Name, property.GetValue(attribute));
                    }
                }
                
            }
        }
    }
}
