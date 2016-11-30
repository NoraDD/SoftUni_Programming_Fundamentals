using System;


namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Hello";
            string text2 = "World";
            string twoWords = $"{text1} {text2}";
            Console.WriteLine(twoWords);
        }
    }
}
