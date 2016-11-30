using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int longestSeq = 0;
            int counter = 1;
            int number = 0;

            for (int index = 0; index < numbers.Length - 1; index++)
            {
                if (numbers[index] == numbers[index + 1])
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
                    number = numbers[index];
                }
            }

            for (int i = 0; i < longestSeq; i++)
            {
                Console.Write("{0} ", number);
            }
        }
    }
}
