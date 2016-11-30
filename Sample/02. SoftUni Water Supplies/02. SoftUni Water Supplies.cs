using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Water_Supplies
{
    class Program
    {
        static void Main()
        {
            double totalAmountWater = double.Parse(Console.ReadLine());
            var bottleToFill = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double bottleCapacity = double.Parse(Console.ReadLine());

            var bottlesLeft = new List<int>();

            double waterNeeded = 0;

            if (totalAmountWater % 2 == 0)
            {
                for (int i = 0; i < bottleToFill.Count; i++)
                {
                    double currentRefill = bottleCapacity - bottleToFill[i];

                    if (totalAmountWater >= currentRefill)
                    {
                        totalAmountWater = totalAmountWater - currentRefill;
                    }
                    else
                    {
                        waterNeeded = waterNeeded + currentRefill - totalAmountWater;
                        totalAmountWater = 0;
                        bottlesLeft.Add(i);
                    }
                }
            }

            else
            {
                for (int i = bottleToFill.Count - 1; i >= 0; i--)
                {
                    double currentRefill = bottleCapacity - bottleToFill[i];

                    if (totalAmountWater >= currentRefill)
                    {
                        totalAmountWater = totalAmountWater - currentRefill;
                    }
                    else
                    {
                        waterNeeded = waterNeeded + currentRefill - totalAmountWater;
                        totalAmountWater = 0;
                        bottlesLeft.Add(i);
                    }
                }
            }

            if (waterNeeded == 0)
            {       
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {totalAmountWater}l.");
            }
            else
            { 
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {bottlesLeft.Count}");
                Console.WriteLine($"With indexes: {string.Join(", ", bottlesLeft)}");
                Console.WriteLine($"We need {waterNeeded} more liters!");
            }
        }
    }
}

