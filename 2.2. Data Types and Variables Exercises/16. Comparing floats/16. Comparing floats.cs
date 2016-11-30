using System;


namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double diffBetweenNum1NUm2 = Math.Abs(num1 - num2);

            if (diffBetweenNum1NUm2 > eps || diffBetweenNum1NUm2 == eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
