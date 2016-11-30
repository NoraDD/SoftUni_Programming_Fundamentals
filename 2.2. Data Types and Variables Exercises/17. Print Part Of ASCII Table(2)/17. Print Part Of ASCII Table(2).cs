using System;


namespace _17.Print_Part_Of_ASCII_Table_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char cha = Convert.ToChar(a);
            char chb = Convert.ToChar(b);

            while (cha <= chb)
            {
                Console.Write("{0} ", cha);
                cha++;
            }
            Console.WriteLine();
        }
    }
}
