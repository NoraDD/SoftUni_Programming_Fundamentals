using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
                for (int r = 0; r < nums.Length - 1; r++)
                {
                    for (int i = 0; i < nums.Length - 1; i++)
                    {
                        nums[i] = nums[i] + nums[i + 1];
                    }
                }
            Console.WriteLine(nums[0]);
        }
    }
}
