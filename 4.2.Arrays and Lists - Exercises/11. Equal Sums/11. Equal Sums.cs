using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long leftSum = 0;
            long rightSum = 0;
            bool equalSum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum = leftSum + numbers[j];
                }

                for (int k = i + 1; k < numbers.Length; k++)
                {
                    rightSum = rightSum + numbers[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    equalSum = true;
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (!equalSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
