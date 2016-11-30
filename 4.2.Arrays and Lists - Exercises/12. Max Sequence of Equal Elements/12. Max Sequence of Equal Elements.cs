using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var len = 1;
            var maxLen = 1;
            var maxNumbers = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    len++;

                    if (len > maxLen)
                    {
                        maxLen = len;
                        maxNumbers = numbers[i];
                    }
                }

                else
                {
                    len = 1;
                }
            }

            if (maxLen == 1)
            {
                maxNumbers = numbers[0];
                Console.WriteLine(maxNumbers);
            }

            else
            {
                for (int i = 0; i < maxLen; i++)
                {
                    Console.Write(maxNumbers + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
