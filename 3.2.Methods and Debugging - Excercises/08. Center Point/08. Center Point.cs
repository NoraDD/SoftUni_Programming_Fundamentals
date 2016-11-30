using System;


namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintPointsToCenterPoint(x1, y1, x2, y2);
        }

        static void PrintPointsToCenterPoint(double x1, double y1, double x2, double y2)
        {
            double x = 0.0;
            double y = 0.0;

            if (Math.Abs(x - x1) <= Math.Abs(x - x2) && Math.Abs(y - y1) <= Math.Abs(y - y2))
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else 
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }  
        }
    }
}
