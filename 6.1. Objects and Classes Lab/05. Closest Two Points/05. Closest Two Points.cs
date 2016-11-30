using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Program
    {
        static void Main()
        {
            Point[] points = ReadPoints();

            Point[] closest2Points = FindClosestTwoPoints(points);

            PrintDistance(closest2Points);

            Printpoint(closest2Points[0]);
            Printpoint(closest2Points[1]);
        }

        static void Printpoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = new Point[2];
            for (int i1 = 0; i1 < points.Length; i1++)
            {
                for (int i2 = i1 + 1; i2 < points.Length; i2++)
                {
                    double distance = CalculateDistance(points[i1], points[i2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints[0] = points[i1];
                        closestTwoPoints[1] = points[i2];
                    }
                }
            }
            return closestTwoPoints;
        }

        static void PrintDistance(Point[] points)
        {
            double distance = CalculateDistance(points[0], points[1]);
            Console.WriteLine("{0:f3}", distance);

        }

        static double CalculateDistance(Point point1, Point point2)
        {
            double sideA = point1.X - point2.X;
            double sideB = point1.Y - point2.Y;
            double distan = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distan;
        }

        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
        }

        static Point ReadPoint()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point();
            p.X = array[0];
            p.Y = array[1];

            return p;
        }
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

