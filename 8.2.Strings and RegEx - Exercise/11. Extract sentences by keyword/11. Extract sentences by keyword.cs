using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.Extract_sentences_by_keyword
{
    class Program
    {
        static void Main()
        {
            string keyword = Console.ReadLine();
            string regexPattern = @"((?<=[.!?]|^)(([^\w.?!]|^)+\w*[^\w.?!]*)*[^\w\.\?!]+(" + keyword + @")[^\w\.\?!]+([^\w.?!]*\w*[^\w.!?]*)*)(?:[.!?]+)";
            string text = Console.ReadLine();

            foreach (Match match in Regex.Matches(text, regexPattern))
            {
                Console.WriteLine(match.Groups[1].Value);
            }
        }
    }
}
