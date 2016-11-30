using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End_2_
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int smallerArrayLength = Math.Min(firstArray.Length, secondArray.Length);

            int leftCounter = CheckArrays(smallerArrayLength, firstArray, secondArray);

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            int rightCounter = CheckArrays(smallerArrayLength, firstArray, secondArray);

            Console.WriteLine(Math.Max(rightCounter, leftCounter));
        }

        private static int CheckArrays(int smallerArrayLength, string[] firstArray, string[] secondArray)
        {
            int counter = 0;

            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }
}
