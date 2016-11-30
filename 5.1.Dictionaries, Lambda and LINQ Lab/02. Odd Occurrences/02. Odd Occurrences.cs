using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var w in words)
            {
                if (counts.ContainsKey(w))
                {
                    counts[w]++;
                }
                else
                {
                    counts[w] = 1;
                }
            }

            var list = new List<string>();

            foreach (var pair in counts)
            {
                if (pair.Value % 2 != 0)
                {
                    list.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}

