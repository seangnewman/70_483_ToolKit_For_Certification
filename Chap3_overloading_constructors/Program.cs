using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_overloading_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student();
            Student secondStudent = new Student("Kwahi", "Leonard");
            Student thirdStudent = new Student("Kevin", "Durant", "Golden State", 99); 
        }
    }
}
