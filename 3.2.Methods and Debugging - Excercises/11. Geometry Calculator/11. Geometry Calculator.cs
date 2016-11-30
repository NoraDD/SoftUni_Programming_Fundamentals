using System;


namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string figureType = Console.ReadLine();

            switch (figureType)
            {
                case "triangle":
                    double sideTriangle = double.Parse(Console.ReadLine());
                    double heightTriangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", FindTriangleArea(sideTriangle, heightTriangle));
                    break;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", FindSquareArea(sideSquare));
                    break;
                case "rectangle":
                    double widthRectangle = double.Parse(Console.ReadLine());
                    double heightRectangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", FindRectangleArea(widthRectangle, heightRectangle));
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", FindCircleArea(radius));
                    break;
            }
        }

        static double FindTriangleArea(double sideTriangle, double heiheightTriangleght)
        {
            double result = (sideTriangle * heiheightTriangleght) / 2;
            return result;
        }

        static double FindSquareArea(double sideSquare)
        {
            double result = sideSquare * sideSquare;
            return result;
        }

        static double FindRectangleArea(double widthRectangle, double heightRectangle)
        {
            double result = widthRectangle * heightRectangle;
            return result;
        }
        static double FindCircleArea(double radius)
        {
            double result = Math.PI * radius * radius;
            return result;
        }
    }
}
