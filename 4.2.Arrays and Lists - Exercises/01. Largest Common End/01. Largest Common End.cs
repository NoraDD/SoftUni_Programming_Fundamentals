using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            var smallerArrayLength = Math.Min(firstArray.Length, secondArray.Length);

            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftCounter++;
                } 
            }

            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    rightCounter++;
                }
            }

            Console.WriteLine(Math.Max(rightCounter, leftCounter));
        }
    }
}
