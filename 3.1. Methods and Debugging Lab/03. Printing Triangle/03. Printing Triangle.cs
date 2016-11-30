using System;


namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        private static void PrintTriangle(int n)
        {
            UpperPartOfTriangle(n);
            LowerPartOfTriangle(n);
        }

        private static void UpperPartOfTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row - 1; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine(row);
            }
        }

        private static void LowerPartOfTriangle(int n)
        {
            for (int row = n-1; row >= 1; row--)
            {
                for (int col = 1; col <= row - 1; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine(row);
            }
        }
    }
}

