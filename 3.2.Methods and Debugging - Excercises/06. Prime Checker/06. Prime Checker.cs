using System;


namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            var result = IsPrime(n);
            Console.WriteLine(result);
        }

        static bool IsPrime(long n)
        {
            bool isPrime = true;

            if (n < 2)
            {
                isPrime = false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
