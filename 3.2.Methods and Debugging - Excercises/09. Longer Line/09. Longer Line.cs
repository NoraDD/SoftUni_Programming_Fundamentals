using System;


namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintPointsToCenterPoint(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void PrintPointsToCenterPoint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double x = 0.0;
            double y = 0.0;

            if (Math.Abs(x - x1) < Math.Abs(x - x3) && Math.Abs(y - y1) < Math.Abs(y - y3) &&
                Math.Abs(x - x2) < Math.Abs(x - x4) && Math.Abs(y - y2) < Math.Abs(y - y4))
            {
                if (Math.Abs(x - x3) <= Math.Abs(x - x4) && Math.Abs(y - y3) <= Math.Abs(y - y4))
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
                }
            }

            else if (Math.Abs(x - x1) >= Math.Abs(x - x3) && Math.Abs(y - y1) >= Math.Abs(y - y3) &&
                Math.Abs(x - x2) >= Math.Abs(x - x4) && Math.Abs(y - y2) >= Math.Abs(y - y4))
            {
                if (Math.Abs(x - x1) <= Math.Abs(x - x2) && Math.Abs(y - y1) <= Math.Abs(y - y2))
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
                }
            }
        }
    }
}
