using System;


namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string variableInHex = Console.ReadLine();
            int number = Convert.ToInt32(variableInHex, 16);
            Console.WriteLine(number);
        }
    }
}
