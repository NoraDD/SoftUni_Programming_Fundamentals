using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Thea_the_Photographer
{
    class Program
    {
        static void Main()
        {
            int totalPictures = int.Parse(Console.ReadLine());
            int filterTimeInSeconds = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long overallFilterTime = (long)totalPictures * filterTimeInSeconds;
            long filteredPictures = (long)Math.Ceiling((double)filterFactor * totalPictures / 100);
            long overallUploadTime = filteredPictures * uploadTime;

            long totalTimeInSec = overallFilterTime + overallUploadTime;

            TimeSpan timeSpan = TimeSpan.FromSeconds(totalTimeInSec);

            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                            timeSpan.Days,    
                            timeSpan.Hours,
                            timeSpan.Minutes,
                            timeSpan.Seconds
                            );
        }
    }
}
