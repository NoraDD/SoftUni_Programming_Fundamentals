using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Work_Days
{
    class Program
    {
        static void Main()
        {
            string startDateText = Console.ReadLine();
            string endDateText = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(startDateText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endDateText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingDays = 0;

            DateTime[] officialHolidays = new DateTime[]
            {
                new DateTime(2016, 01, 01),
                new DateTime(2016, 03, 03),
                new DateTime(2016, 05, 01),
                new DateTime(2016, 05, 06),
                new DateTime(2016, 05, 24),
                new DateTime(2016, 09, 06),
                new DateTime(2016, 09, 22),
                new DateTime(2016, 11, 01),
                new DateTime(2016, 12, 24),
                new DateTime(2016, 12, 25),
                new DateTime(2016, 12, 26)
            };

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                DateTime newDate = new DateTime(2016, currentDate.Month, currentDate.Day);

                DayOfWeek day = currentDate.DayOfWeek;

                if (!(day.Equals(DayOfWeek.Saturday) || day.Equals(DayOfWeek.Sunday) || officialHolidays.Contains(newDate)))

                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
