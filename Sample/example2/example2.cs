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

            var arr2 = new string[5];
            arr2[0] = "4";
            arr2[1] = "5";
            arr2[2] = "6";
            arr2[3] = "7";
            arr2[4] = "8";

            var minLength = Math.Min(arr1.Length, arr2.Length);

            var length = arr1.Length + arr2.Length;

            var arr3 = new string[length];

            var counter = 0;

            for (int i = 0; i < minLength; i++, counter++)
            {
                arr3[counter] = arr1[i];
                counter++;
                arr3[counter] = arr2[i];
            }

            for (int i = minLength; i <length - minLength; i++, counter++)
            {
                arr3[counter] = arr2[i];      
            }
           Console.WriteLine(string.Join(" ", arr3));
        }    
    }
}
