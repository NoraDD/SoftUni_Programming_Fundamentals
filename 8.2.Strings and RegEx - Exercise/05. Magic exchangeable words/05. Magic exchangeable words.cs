using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstStr = input[0];
            string secondStr = input[1];

            if (AreExchangeable(firstStr, secondStr))
                Console.WriteLine("true");

            else
                Console.WriteLine("false");
        }

        static bool AreExchangeable(string firstStr, string secondStr)
        {
           
            Dictionary<char, char> firstCharCorrelations = new Dictionary<char, char>();
            Dictionary<char, char> secondCharCorrelations = new Dictionary<char, char>();
            for (int i = 0; i < Math.Max(firstStr.Length, secondStr.Length); i++)
            {
                if (i >= firstStr.Length)
                {
                    
                    char secondStrChar = secondStr[i];
                    if (!secondCharCorrelations.ContainsKey(secondStrChar))
                        return false;
                }
                else if (i >= secondStr.Length)
                {
                   
                    char firstStrChar = firstStr[i];
                    if (!firstCharCorrelations.ContainsKey(firstStrChar))
                        return false;
                }
                else
                {
                    char firstStrChar = firstStr[i];
                    char secondStrChar = secondStr[i];

                  
                    if (!firstCharCorrelations.ContainsKey(firstStrChar))
                    {
                        firstCharCorrelations[firstStrChar] = secondStrChar;
                    }
                    if (!secondCharCorrelations.ContainsKey(secondStrChar))
                    {
                        secondCharCorrelations[secondStrChar] = firstStrChar;
                    }

                    if (firstCharCorrelations[firstStrChar] != secondStrChar)
                        return false;
                    if (secondCharCorrelations[secondStrChar] != firstStrChar)
                        return false;
                }
            }

            return true;
        }
    }
}
