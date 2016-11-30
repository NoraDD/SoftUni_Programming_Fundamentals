using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotations = int.Parse(Console.ReadLine());

            int[] sumOfRotations = new int[numbers.Length];

            for (int currentRotation = 0; currentRotation < rotations; currentRotation++)
            {
                int lastElement = numbers[numbers.Length - 1];

                for (int currentElement = numbers.Length-1; currentElement > 0; currentElement--)
                {
                    numbers[currentElement] = numbers[currentElement - 1];
                }

                numbers[0] = lastElement;

                for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
                {
                    sumOfRotations[currentElement] += numbers[currentElement];
                }
            }

            Console.WriteLine(string.Join(" ", sumOfRotations));        
        }
    }
}
