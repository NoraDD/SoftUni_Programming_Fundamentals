using System;


namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                Console.WriteLine("{0:F2}", FindFaceDiagonals(sideCube));
            }
            else if (parameter == "space")
            {
                Console.WriteLine("{0:F2}", FindSpaceDiagonals(sideCube));
            }
            if (parameter == "volume")
            {
                Console.WriteLine("{0:F2}", FindVolume(sideCube));
            }
            if (parameter == "area")
            {
                Console.WriteLine("{0:F2}", FindSurfaceArea(sideCube));
            }
        }

        static double FindFaceDiagonals(double sideCube)
        {
            double result = Math.Sqrt(2 * sideCube * sideCube);
            return result;
        }

        static double FindSpaceDiagonals(double sideCube)
        {
            double result = Math.Sqrt(3 * sideCube * sideCube);
            return result;
        }

        static double FindVolume(double sideCube)
        {
            double result = sideCube * sideCube * sideCube;
            return result;
        }
        static double FindSurfaceArea(double sideCube)
        {
            double result = 6 * sideCube * sideCube;
            return result;
        }
    }
}
