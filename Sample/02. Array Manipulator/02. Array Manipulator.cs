using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[] command = Console.ReadLine().Split();

            while (!command.Contains("end"))
            {
                switch (command[0])
                {
                    case "exchange":
                        {
                            int index = int.Parse(command[1]);

                            if (index < array.Length && index >= 0)
                            {
                                List<int> tempArray = new List<int>();
                                tempArray.AddRange(array.Skip(index + 1).Take(array.Length - index + 1));
                                tempArray.AddRange(array.Take(index + 1));

                                for (int i = 0; i < array.Length; i++)
                                {
                                    array[i] = tempArray[i];
                                }
                            }
                            else Console.WriteLine("Invalid index");
                            break;
                        }

                    case "max":
                        {
                            if (command[1] == "even")
                            {
                                int[] evens = GetEvens(array);
                                if (evens.Length == 0)
                                {
                                    Console.WriteLine("No matches");
                                    break;
                                }
                                Console.WriteLine(Array.LastIndexOf(array, evens.Max()));
                            }
                            else if (command[1] == "odd")
                            {
                                int[] odds = GetOdds(array);
                                if (odds.Length == 0)
                                {
                                    Console.WriteLine("No matches");
                                    break;
                                }
                                Console.WriteLine(Array.LastIndexOf(array, odds.Max()));
                            }
                            break;
                        }

                    case "min":
                        {
                            if (command[1] == "even")
                            {
                                int[] evens = GetEvens(array);
                                if (evens.Length == 0)
                                {
                                    Console.WriteLine("No matches");
                                    break;
                                }
                                Console.WriteLine(Array.LastIndexOf(array, evens.Min()));
                            }
                            else if (command[1] == "odd")
                            {
                                int[] odds = GetOdds(array);
                                if (odds.Length == 0)
                                {
                                    Console.WriteLine("No matches");
                                    break;
                                }
                                Console.WriteLine(Array.LastIndexOf(array, odds.Min()));
                            }
                            break;
                        }

                    case "first":
                        {
                            int index = int.Parse(command[1]);

                            if (index <= array.Length && index > 0)
                            {
                                if (command[2] == "even")
                                {
                                    int[] evens = GetEvens(array);
                                    if (evens.Length == 0)
                                    {
                                        Console.WriteLine("[]");
                                        break;
                                    }
                                    Console.WriteLine("[" + string.Join(", ", evens.Take(index)) + "]");
                                }
                                else if (command[2] == "odd")
                                {
                                    int[] odds = GetOdds(array);
                                    if (odds.Length == 0)
                                    {
                                        Console.WriteLine("[]");
                                        break;
                                    }
                                    Console.WriteLine("[" + string.Join(", ", odds.Take(index)) + "]");
                                }
                            }
                            else Console.WriteLine("Invalid count");
                            break;
                        }

                    case "last":
                        {
                            int index = int.Parse(command[1]);

                            if (index <= array.Length && index > 0)
                            {
                                if (command[2] == "even")
                                {
                                    int[] evens = GetEvens(array);
                                    if (evens.Length == 0)
                                    {
                                        Console.WriteLine("[]");
                                        break;
                                    }
                                    Console.WriteLine("[" + string.Join(", ", evens.Skip(evens.Length - index).Take(index)) + "]");
                                }
                                else if (command[2] == "odd")
                                {
                                    int[] odds = GetOdds(array);
                                    if (odds.Length == 0)
                                    {
                                        Console.WriteLine("[]");
                                        break;
                                    }
                                    Console.WriteLine("[" + string.Join(", ", odds.Skip(odds.Length - index).Take(index)) + "]");
                                }
                            }
                            else Console.WriteLine("Invalid count");
                            break;
                        }
                }
                command = Console.ReadLine().Split();
            }

            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

        private static int[] GetOdds(int[] array)
        {
            return array.Where(x => x % 2 != 0).ToArray();
        }

        private static int[] GetEvens(int[] array)
        {
            return array.Where(x => x % 2 == 0).ToArray();
        }
    }
}

