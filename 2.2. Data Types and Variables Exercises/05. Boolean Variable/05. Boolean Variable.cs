using System;


namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            if (Convert.ToBoolean(text) == false)
            {
                Console.WriteLine("No");
            }
            else 
            {
                Console.WriteLine("Yes");
            }
            

        }
    }
}
