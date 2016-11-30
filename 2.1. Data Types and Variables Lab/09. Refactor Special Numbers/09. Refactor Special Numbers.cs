using System;


namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int howManyNumbers = int.Parse(Console.ReadLine());
             for (int number = 1; number <= howManyNumbers; number++)
            {
                int sumOfDigits = 0;
                int digits = number;
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number = number / 10;
                }
                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{digits} -> {special}");
                sumOfDigits = 0;
                number = digits;
            }
        }
    }
}
