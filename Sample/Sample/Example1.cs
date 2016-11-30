using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main()
        {
            var arr1 = new string[3];
            arr1[0] = "1";
            arr1[1] = "2";
            arr1[2] = "3";

            var arr2 = new string[3];
            arr2[0] = "4";
            arr2[1] = "5";
            arr2[2] = "6";

            var length = arr1.Length + arr2.Length;

            var arr3 = new string[length];

            var counter = 0;

            for (int i = 0; i < arr3.Length; i++, counter++)
            {
                if ((i % 2 == 0) || (i == 0))
                {
                    arr3[i] = arr1[counter];
                }
                else
                {
                    counter--;
                    arr3[i] = arr2[counter];
                }
            }
            Console.WriteLine(string.Join(" ", arr3));
        }
    }
}
