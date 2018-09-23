using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chap8_Assembly
{
    public partial class Form1 : Form
    {

        private enum MyCustomEnum
        {
            Red = 1,
            White = 2,
            Blue = 3
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string systemData = "System.Data";
            string version = "4.0.0.0";
            string culture = "neutral";
            string publicKeyToken = "b77a5c561934e089";
            string assemblyString = String.Format("{0}, Version={1}, Culture = {2}, PublicKeyToken={3}", systemData, version, culture, publicKeyToken);

            Assembly myAssembly = Assembly.Load(assemblyString);


            Debug.WriteLine("CodeBase: {0}", myAssembly.CodeBase);
            Debug.WriteLine("FullName: {0}", myAssembly.FullName);
            Debug.WriteLine("GlobalAssemblyCache: {0}", myAssembly.GlobalAssemblyCache);
            Debug.WriteLine("ImageRuntimeVersion: {0}", myAssembly.ImageRuntimeVersion);
            Debug.WriteLine("Location: {0}", myAssembly.Location);

            displayTypes();
            displayModules(systemData, version, culture, publicKeyToken);

            createInstance(myAssembly);
            getReferencedAssemblies(myAssembly);

            createInstanceVariable();

            returnArrayRank();
            returnConstructorInfo();
            returnEnums();
            returnFields();
            returnFields();

        }

        private static void displayTypes()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Type[] myAssemblyTypes = myAssembly.GetTypes();

            foreach (Type myType in myAssemblyTypes)
            {
                Debug.WriteLine(String.Format("myType Name : {0}", myType.Name));
            }
        }

        private static void displayModules(string systemData, string version, string culture, string publicKeyToken)
        {
            string assemblyString = String.Format("{0}, Version={1}, Culture = {2}, PublicKeyToken={3}", systemData, version, culture, publicKeyToken);

            Assembly myAssembly = Assembly.Load(assemblyString);

            Module[] myAssemblyModules = myAssembly.GetModules();

            foreach (Module myModule in myAssemblyModules)
            {
                Debug.WriteLine(string.Format("myModule Name: {0}", myModule.Name));
            }
        }

        private static void createInstance(Assembly myAssembly)
        {
            

            DataTable dt = (DataTable)myAssembly.CreateInstance("System.Data.DataTable");

            Debug.Print("Number of rows: {0}", dt.Rows.Count);
        }

        private static void getReferencedAssemblies(Assembly myAssembly)
        {
            AssemblyName[] referencedAssemblyNames = myAssembly.GetReferencedAssemblies();

            foreach (AssemblyName assemblyName in referencedAssemblyNames)
            {
                Debug.WriteLine("Assembly Name: {0}", assemblyName.Name);
                Debug.WriteLine("Assembly Version: {0}", assemblyName.Version);
            }
        }

        private void createInstanceVariable( )
        {
            int myIntVariable = 0;
            System.Type myType = myIntVariable.GetType();
            Debug.WriteLine("AssemblyQualifiedName: {0}", myType.AssemblyQualifiedName);
            Debug.WriteLine("FullName: {0}", myType.FullName);
            Debug.WriteLine("IsValueType: {0}", myType.IsValueType);
            Debug.WriteLine("Name: {0}", myType.Name);
            Debug.WriteLine("Namespace: {0}", myType.Namespace);
        }

        private static void returnArrayRank()
        {
            int[,,] myIntArray = new int[5, 6, 7];
            Type myIntArrayType = myIntArray.GetType();
            Debug.Print("Array Rank: {0}", myIntArrayType.GetArrayRank());
        }

        private static void returnConstructorInfo()
        {
            DataTable myDataTable = new DataTable();
            Type myDataTableType = myDataTable.GetType();
            ConstructorInfo[] myDataTableConstructors = myDataTableType.GetConstructors();

            for (int i = 0; i < myDataTableConstructors.Length -1 ; i++)
            {
                ConstructorInfo constructorInfo = myDataTableConstructors[i];
                Debug.Print("\nConstructor #{0}", i + 1);

                ParameterInfo[] parameters = constructorInfo.GetParameters();
                Debug.Print("Number of Parameters: {0}", parameters.Length);

                foreach (ParameterInfo parameter in parameters)
                {
                    Debug.Print("Parameter Name: {0}", parameter.Name);
                    Debug.Print("Parameter Type: {0}", parameter.ParameterType.Name);
                }
            }
        }

        private void returnEnums()
        {
            Type myCustomEnumType = typeof(MyCustomEnum);

            string[] enumNames = myCustomEnumType.GetEnumNames();

            foreach (string enumName in enumNames)
            {
                Debug.Print(String.Format("Name {0}", enumName));
            }

            Array enumValues = myCustomEnumType.GetEnumValues();
            foreach (object enumValue in enumValues)
            {
                Debug.Print("Enum Value: {0}", enumValue.ToString());
            }

            for (int i = 1; i <= 3; i++)
            {
                string enumName = myCustomEnumType.GetEnumName(i);
                Debug.Print(String.Format("{0}: {1}", enumName, i));
            }
             
            
        }

        private static void returnFields()
        {
            ReflectionExample reflectionExample = new ReflectionExample();
            Type reflectionExampleType = typeof(ReflectionExample);

            FieldInfo[] fields = reflectionExampleType.GetFields(
                BindingFlags.Public | BindingFlags.Instance | 
                BindingFlags.Static | BindingFlags.NonPublic |
                BindingFlags.FlattenHierarchy);

            foreach (FieldInfo field in fields)
            {
                object fieldValue = field.GetValue(reflectionExample);

                Debug.WriteLine(string.Format("Field Name : {0}, Value: {1}", field.Name, fieldValue.ToString()));
            }

            reflectionExampleType.GetField("privateField", BindingFlags.NonPublic |
                                                           BindingFlags.Instance )
                                                            .SetValue(reflectionExample, "My New Value");
            Debug.Print("Private Field Value: {0}", reflectionExample.PrivateField);
        }

 


    }
}
