using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                string pattern = @"<a.*?href\s*=("".*?"").*>(.*?)<\/a>";

                string replace = @"[URL href=$1]$2[/URL]";

                Regex regex = new Regex(pattern);
                string result = Regex.Replace(text, pattern, replace);
                
                Console.WriteLine(result);

                text = Console.ReadLine();
            }
        }
    }
}
