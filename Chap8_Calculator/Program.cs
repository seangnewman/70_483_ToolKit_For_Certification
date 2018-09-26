using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeCompileUnit codeCompileunit = new CodeCompileUnit();
            CodeNamespace codeNamespace = new CodeNamespace("Chap8_Calculator");

            codeNamespace.Imports.Add(new CodeNamespaceImport("System"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Collections.Generic"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Linq"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Text"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Threading.Tasks"));
           

        }
    }
}
