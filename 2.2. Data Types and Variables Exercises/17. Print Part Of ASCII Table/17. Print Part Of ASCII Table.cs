using System;


namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char cha = Convert.ToChar(a);
            char chb = Convert.ToChar(b);

            for (int i = cha; i <= chb; i++)
            {
                Console.Write("{0} ", (char)i);
            }
            Console.WriteLine();
        }
    }
}
