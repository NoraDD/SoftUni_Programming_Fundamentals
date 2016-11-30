using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main()
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            string[] arrays = { new string(firstArray), new string(secondArray) };
            Console.WriteLine(string.Join("\n", arrays.OrderBy(str => str)));
        }
    }
}
