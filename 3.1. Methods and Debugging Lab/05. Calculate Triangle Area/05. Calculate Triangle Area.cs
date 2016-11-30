using System;


namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetTriangeArea(width, height));
        }

        static double GetTriangeArea(double width, double height)
        {
            double triangleArea = width * height / 2;
            return triangleArea;
        }
    }
}
