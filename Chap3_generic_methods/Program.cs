using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_generic_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInts = new int[] { 2, 5, 4, 7, 6, 7, 1, 3, 9, 8 };
            char[] arrChar = new char[] { 'f', 'a', 'r', 'c', 'h' };

            // Sorting integer Sort
            for (int i = 0; i < arrInts.Length; i++)
            {
                for (int j = 0; j < arrInts.Length; j++)
                {
                    if (arrInts[i] > arrInts[j])
                    {
                        swap<int>(ref arrInts[i], ref arrInts[j]);
                    }
                }
            }

            // Sorting char Sort
            for (int i = 0; i < arrChar.Length; i++)
            {
                for (int j = 0; j < arrChar.Length; j++)
                {
                    if (arrChar[i] > arrChar[j])
                    {
                        swap<char>(ref arrChar[i], ref arrChar[j]);

                    }
                }

            }
        }

        private static void swap<T>(ref T valueOne, ref T valueTwo)
        {
            T temp = valueOne;
            valueOne = valueTwo;
            valueTwo = temp;
        }
    }
}
