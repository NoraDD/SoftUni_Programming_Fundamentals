using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUni_Airline
{
    class Program
    {
        static void Main()
        {
            int numberOfFlights = int.Parse(Console.ReadLine());
            decimal overallProfit = 0m;

            for (int i = 0; i < numberOfFlights; i++)
            {
                uint adultPassengersCount = uint.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                uint youthPassengersCount = uint.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = (adultPassengersCount * adultTicketPrice) + (youthPassengersCount*youthTicketPrice);
                decimal expenses = flightDuration * fuelConsumptionPerHour * fuelPricePerHour;

                decimal diff = income - expenses;

                if (income >= expenses)
                {
                    Console.WriteLine("You are ahead with {0:F3}$.", diff);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:F3}$.", diff);
                }

                overallProfit += diff;
            }

            Console.WriteLine("Overall profit -> {0:F3}$.", overallProfit);
            Console.WriteLine("Average profit -> {0:F3}$.", overallProfit/numberOfFlights);
        }
    }
}
