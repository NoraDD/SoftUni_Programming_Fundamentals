using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                           .ToLower()
                           .Split(new char[] { ':', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }
                           , StringSplitOptions.RemoveEmptyEntries)
                           .ToArray();
            string[] result = words
                            .Where(word => word.Length < (5))
                            .OrderBy(word => word)
                            .Distinct().ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
