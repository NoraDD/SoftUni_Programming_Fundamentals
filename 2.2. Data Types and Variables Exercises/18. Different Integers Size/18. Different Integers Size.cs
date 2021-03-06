﻿using System;
using System.Numerics;


namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            bool isSbyte = (n >= -128) && (n <= 127);
            bool isByte = (n >= 0) && (n <= 255);
            bool isShort = (n >=- 32768) && (n <= 32767);
            bool isUshort = (n >= 0) && (n <= 65535);
            bool isInt = (n >= - 2147483648) && (n <= 2147483647);
            bool isUint = (n >= 0) && (n <= 4294967295);
            bool isLong = (n >= -9223372036854775808) && (n <= 9223372036854775807);
            
            if (isByte || isByte || isShort || isUshort || isInt || isUint || isLong)
            {
                Console.WriteLine("{0} can fit in:", n);
                if (isSbyte)
                {
                    Console.WriteLine("* sbyte");
                }
                if (isByte)
                {
                    Console.WriteLine("* byte");
                }
                if (isShort)
                {
                    Console.WriteLine("* short");
                }
                if (isUshort)
                {
                    Console.WriteLine("* ushort");
                }
                if (isInt)
                {
                    Console.WriteLine("* int");
                }
                if (isUint)
                {
                    Console.WriteLine("* uint");
                }
                if (isLong)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", n);
            }
        }
    }
}
