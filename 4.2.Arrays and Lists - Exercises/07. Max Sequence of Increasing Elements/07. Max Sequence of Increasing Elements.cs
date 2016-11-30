using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int longestSeq = 0;
            int counter = 1;
            int endIndex = 0;

            for (int index = 0; index < numbers.Length - 1; index++)
            {
                if (numbers[index] < numbers[index + 1])
                {
                    counter++;
                }
                else
                {

                    counter = 1;
                }

                if (counter > longestSeq)
                {
                    longestSeq = counter;
                    endIndex = index + 2;
                }
            }

            for (int i = endIndex - longestSeq; i < endIndex; i++)
            {
                Console.Write("{0} ", numbers[i]);             
            }
        }
    }
}

