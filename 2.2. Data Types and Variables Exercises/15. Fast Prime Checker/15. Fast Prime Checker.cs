﻿ using System;


namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= number; currentNumber++)
            {
                bool isPrime = true;
                for (int nextNumber = 2; nextNumber <= Math.Sqrt(currentNumber); nextNumber++)
                {
                    if (currentNumber % nextNumber == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }
        }
    }
}
