﻿using System;


namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            GetMaxNum(num1, num2, num3);
        }

        private static void GetMaxNum(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("{0}", num1); 
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("{0}", num2); 
            }
            else if (num3 > num1 && num3 > num1)
            {
                Console.WriteLine("{0}", num3);
            }
        }
    }
}
