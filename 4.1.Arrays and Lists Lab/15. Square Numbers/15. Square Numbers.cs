using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var results = new List<int>();
            foreach (var num in nums)
            {
                if (IsExactSquare(num))
                {
                    results.Add(num);
                }
            }
            results.Sort();
            results.Reverse();
            Console.WriteLine(string.Join(" ", results));
        }

        static bool IsExactSquare(int num)
        {
            return Math.Sqrt(num) == (int)Math.Sqrt(num);
        }
    }
}
