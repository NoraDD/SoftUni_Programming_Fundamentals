using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main()
        {
            string firstNum = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            string sum = firstNum;
            if (multiplier - 1 > 0)
            {
                for (int i = 0; i < multiplier - 1; i++)
                {
                    sum = SumBigNumbers(sum, firstNum);
                }
            }

            if (multiplier == 0)
                sum = "0";
            else if (multiplier < 0)
                sum = "-" + sum;

            Console.WriteLine(sum);
        }

        static string SumBigNumbers(string s1, string s2)
        {
            s2 = s2.PadLeft(s1.Length, '0');
            s1 = s1.PadLeft(s2.Length, '0');

            string sum = "";
            string digitsStr = "";
            bool carry = false;

            for (int i = s1.Length - 1; i >= 0; i--)
            {
                int digitsSum = int.Parse(s1[i].ToString()) + int.Parse(s2[i].ToString());

                if (carry)  
                    digitsSum += 1;

                digitsStr = digitsSum.ToString();

                if (digitsSum >= 10)
                {
                    carry = true;
                    if (i == 0)
                       
                        sum = digitsStr + sum;
                    else
                        sum = digitsStr[digitsStr.Length - 1] + sum;

                }
                else
                {
                    carry = false;
                    sum = digitsStr + sum;
                }
            }

            return new string(sum.ToArray()).TrimStart('0');
        }
    }
}
