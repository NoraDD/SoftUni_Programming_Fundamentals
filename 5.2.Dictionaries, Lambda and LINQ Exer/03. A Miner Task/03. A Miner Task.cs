using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();

            string resourceType = Console.ReadLine();

            while (!resourceType.Equals("stop"))
            {
                long resourceQuantity = long.Parse(Console.ReadLine());

                if (! resources.ContainsKey(resourceType))
                {
                    resources.Add(resourceType, 0);
                }

                resources[resourceType] = resources[resourceType] + resourceQuantity;

                resourceType = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }         
        }
    }
}
