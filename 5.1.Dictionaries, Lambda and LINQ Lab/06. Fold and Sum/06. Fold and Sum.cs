using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = nums.Length / 4;

            int[] row1left = nums.Take(k).Reverse().ToArray();
            int[] row1right = nums.Reverse().Take(k).ToArray();
            int[] row1 = row1left.Concat(row1right).ToArray();
            int[] row2 = nums.Skip(k).Take(2 * k).ToArray();

            var sumNums =
              row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sumNums));
        }
    }
}
