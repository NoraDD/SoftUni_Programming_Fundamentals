using System;


namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long overallFilterTime = (long)pictures * filterTime;
            long filterPictures = (long)Math.Ceiling((double)pictures * filterFactor / 100);
            long overallUploadTime = filterPictures * uploadTime;
            long time = overallUploadTime + overallFilterTime;

            TimeSpan timeSpan = TimeSpan.FromSeconds(time);
            
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", 
                timeSpan.Days,
                timeSpan.Hours,
                timeSpan.Minutes,
                timeSpan.Seconds);
        }
    }
}
