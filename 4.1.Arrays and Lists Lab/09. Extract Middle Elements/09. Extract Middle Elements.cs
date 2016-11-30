using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = ExtractMiddleElementMethod(arr);
            Console.WriteLine("{ " + string.Join(", ", result) + " }");
        }

        static int[] ExtractMiddleElementMethod(int[] arr)
        {
            var len = arr.Length;
            if (len == 1)
            {
                return arr;
            }
            if (len % 2 == 0)
            {
                return new int[] { arr[len / 2 - 1], arr[len / 2] };
            }
            else
            {
                return new int[] { arr[len / 2 - 1], arr[len / 2], arr[len / 2 + 1] };
            }
        }
    }
}
