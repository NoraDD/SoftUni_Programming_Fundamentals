using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine().ToLower().ToArray();
            var result = text.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
