using System;


namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            GetNthFibonacciNumber(n);
        }

        static void GetNthFibonacciNumber(uint n)
        {
            uint fib1 = 1;
            uint fib2 = 0;
            uint nextNumber = 0;

            for (uint i = 0; i <= n; i++)
            {
                nextNumber = fib1 + fib2;
                fib1 = fib2;
                fib2 = nextNumber;
            }
            Console.WriteLine("{0}", fib2);
        }
    }
}
