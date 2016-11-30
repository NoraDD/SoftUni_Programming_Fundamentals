using System;


namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
           int distance = int.Parse(Console.ReadLine());
           int hours = int.Parse(Console.ReadLine());
           int minutes = int.Parse(Console.ReadLine());
           int seconds = int.Parse(Console.ReadLine());

            var time = (hours * 3600 + minutes * 60 + seconds);

            float metersPerSec = (float)distance / time;
            float kilometersPerHour = ((float)distance / 1000) / ((float)time / 3600);
            float milesPerHour = ((float)distance / 1609) / ((float)time / 3600);
            Console.WriteLine(metersPerSec);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
