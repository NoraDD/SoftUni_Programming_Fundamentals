using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> dictKeyMaterials = new Dictionary<string, int>();
            dictKeyMaterials["shards"] = 0;
            dictKeyMaterials["fragments"] = 0;
            dictKeyMaterials["motes"] = 0;

            SortedDictionary<string, int> dictNonKeyMaterials = new SortedDictionary<string, int>();

            bool getMoreMaterials = true;
            string matWin = "";

            while (getMoreMaterials)
            {
                string[] line = Console.ReadLine().Split();
                int numberElements = line.Length;
                for (int i = 0; i < numberElements; i = i + 2)
                {
                    int quantity = int.Parse(line[i]);
                    string material = line[i + 1].ToLower();
                    if (dictKeyMaterials.ContainsKey(material))
                    {
                        dictKeyMaterials[material] = dictKeyMaterials[material] + quantity;
                        if (dictKeyMaterials[material] >= 250)
                        {
                            matWin = material;
                            dictKeyMaterials[material] = dictKeyMaterials[material] - 250;
                            getMoreMaterials = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!dictNonKeyMaterials.ContainsKey(material))
                        {
                            dictNonKeyMaterials[material] = 0;
                        }
                        dictNonKeyMaterials[material] = dictNonKeyMaterials[material] + quantity;
                    }
                }
            }

            dictKeyMaterials = dictKeyMaterials
                .OrderBy(x => x.Key)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            var first = dictKeyMaterials.First();
            var mat = first.Key;
            string cont = getContent(matWin);
            Console.WriteLine($"{cont} obtained!");
            foreach (var kvp in dictKeyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in dictNonKeyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        private static string getContent(string mat)
        {
            if (mat == "shards")
            {
                return "Shadowmourne";
            }
            else if (mat == "fragments")
            {
                return "Valanyr";
            }
            else
            {
                return "Dragonwrath";
            }
        }
    }
}
