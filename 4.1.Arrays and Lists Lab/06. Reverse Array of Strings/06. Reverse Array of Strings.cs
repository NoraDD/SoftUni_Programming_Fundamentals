﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            string[] items = Console.ReadLine().Split(' ').ToArray();
            var reversedItems = items.Reverse();
            Console.WriteLine(string.Join(" ", reversedItems));
        }
    }
}
