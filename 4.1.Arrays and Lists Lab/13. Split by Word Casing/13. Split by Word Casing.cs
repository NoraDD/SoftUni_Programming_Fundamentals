using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Split_by_Word_Casing
{
    class Program
    {
        static void Main()
        {
            var separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            var text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var lowerCaseList = new List<string>();
            var mixedCaseList = new List<string>();
            var upperCaseList = new List<string>();

            foreach (var word in text)
            {
                var type = GetWordType(word);
                if (type == WordType.upperCase)
                {
                    upperCaseList.Add(word);
                }
                else if (type == WordType.lowerCase)
                {
                    lowerCaseList.Add(word);
                }
                else
                {
                    mixedCaseList.Add(word);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseList));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseList));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseList));
        }
        enum WordType { lowerCase, mixedCase, upperCase }

        private static WordType GetWordType(string word)
        {
            var lowerLetters = 0;
            var upperLetters = 0;
            foreach (var l in word)
            {
                if (char.IsUpper(l))
                {
                    upperLetters++;
                }
                else if (char.IsLower(l))
                {
                    lowerLetters++;
                }
            }
            if (upperLetters == word.Length)
            {
                return WordType.upperCase;
            }
            if (lowerLetters == word.Length)
            {
                return WordType.lowerCase;
            }
            return WordType.mixedCase;
        }
    }
}

