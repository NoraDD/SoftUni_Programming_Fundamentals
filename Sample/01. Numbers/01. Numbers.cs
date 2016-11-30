using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var averageNumber = input.Average();

            List<int> list = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > averageNumber)
                {
                    list.Add(input[i]);
                }            
            }

            var output = list.OrderByDescending(num => num).Take(5).ToList();
            string stringOutput = string.Join(" ", output);

            if (stringOutput.Length > 0)
            {
                Console.WriteLine(stringOutput); 
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
