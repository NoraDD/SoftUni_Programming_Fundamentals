using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger bigNumber = 1;
            for (int i = 2; i <= number; i++)
            {
                bigNumber = bigNumber * i;
            }
            Console.WriteLine(bigNumber);
        }
    }
}
