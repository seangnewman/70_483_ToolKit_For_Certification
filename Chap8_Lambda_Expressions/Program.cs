using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_Lambda_Expressions
{
    class Program
    {
        delegate double square(double x);
        delegate bool GreaterThan(double x, double y);

        static void Main(string[] args)
        {
            square myLambdaExpression = x => x* x;
            Console.WriteLine("X squared is {0}", myLambdaExpression(5));

            GreaterThan gt = (x,y) => x > y;
            Console.WriteLine("Is {0} greater than {1}? {2}", 6 , 5, gt(6,5));
        }
    }
}
