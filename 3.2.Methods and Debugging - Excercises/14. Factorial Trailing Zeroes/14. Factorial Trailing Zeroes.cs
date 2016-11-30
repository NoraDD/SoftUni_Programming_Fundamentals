using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = n; i > 1; i--)
            {
                factorial = BigInteger.Multiply(factorial, i);
            }

            var result = CountZerosInFactorial(n);
            Console.WriteLine(result);
        }

        static int CountZerosInFactorial(int n)
        {
            int result = 0;
            int start = 1;
            while (n >= start)
            {
                start *= 5;
                result += (int)n / start;
            }
            return result;
        }
    }
}


