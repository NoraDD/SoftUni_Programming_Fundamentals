using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Intersection_of_Circles
{
    class Program
    {
        static void Main()
        {
            int[] cirInfo1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] cirInfo2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Circle c1 = ReadCircle(cirInfo1);
            Circle c2 = ReadCircle(cirInfo2);

            double radiusSum = cirInfo1[2] + cirInfo2[2];
            double distance = CalcDistance(cirInfo1, cirInfo2);

            Console.WriteLine(IsIntersect(distance, radiusSum) ? "Yes" : "No");
        }

        static Point ReadPoint(int[] cirInfo)
        {
            Point p = new Point();
            p.X = cirInfo[0];
            p.Y = cirInfo[1];
            return p;
        }

        static Circle ReadCircle(int[] cirInfo)
        {
            Circle cir = new Circle();
            cir.X = cirInfo[0];
            cir.Y = cirInfo[1];
            cir.Radius = cirInfo[2];
            return cir;
        }

        static double CalcDistance(int[] cirInfo1, int[] cirInfo2)
        {
            Point p1 = ReadPoint(cirInfo1);
            Point p2 = ReadPoint(cirInfo2);
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static bool IsIntersect(double distance, double radiusSum)
        {
            bool isIntersect = (distance <= radiusSum);
            return isIntersect;
        }
    }

    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius{ get; set; }

    }
     
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

}
