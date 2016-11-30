using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Nacepin
{
    class Program
    {
        static void Main()
        {
            double priceUsStore = double.Parse(Console.ReadLine());
            double boxWeightUs = double.Parse(Console.ReadLine());
            double priceUkStore = double.Parse(Console.ReadLine());
            double boxWeightUk = double.Parse(Console.ReadLine());
            double priceChineseStore = double.Parse(Console.ReadLine());
            double boxWeightChinese = double.Parse(Console.ReadLine());

            double priceUs = (priceUsStore / 0.58) / boxWeightUs;
            double priceUk = (priceUkStore / 0.41) / boxWeightUk;
            double priceChinese = (priceChineseStore * 0.27) / boxWeightChinese;

            double lowestPrice = Math.Min(priceUs, Math.Min(priceUk, priceChinese));
            double highestPrice = Math.Max(priceUs, Math.Max(priceUk, priceChinese));
            double diff = Math.Abs(highestPrice - lowestPrice);

            if (priceUs < priceUk && priceUs < priceChinese)
            {
                Console.WriteLine("US store. {0:F2} lv/kg", lowestPrice);
                Console.WriteLine("Difference {0:F2} lv/kg", diff);
            }
            else if (priceUk < priceUs && priceUk < priceChinese)
            {
                Console.WriteLine("UK store. {0:F2} lv/kg", lowestPrice);
                Console.WriteLine("Difference {0:F2} lv/kg", diff);
            }
            else if (priceChinese < priceUs && priceChinese < priceUk)
            {
                Console.WriteLine("Chinese store. {0:F2} lv/kg", lowestPrice);
                Console.WriteLine("Difference {0:F2} lv/kg", diff);
            }

        }
    }
}
