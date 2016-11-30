using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main()
        {
           
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();

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

            Console.WriteLine(new string(sum.ToArray()).TrimStart('0'));
        }
    }
}
