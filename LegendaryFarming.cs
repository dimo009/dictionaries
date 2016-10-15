using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {

            var materials = new Dictionary<string, long>();
            materials.Add("fragments", 0);
            materials.Add("shards", 0);
            materials.Add("motes", 0);
            int count = 1;

            while (count != 10)
            {
                string[] input = Console.ReadLine().ToLower().Split().ToArray();
                var obtainedElement = "";


                for (int i = 1; i < input.Length; i = i + 2)
                {
                    int quantity = int.Parse(input[i - 1]);
                    string rawMat = input[i];

                    if (!materials.ContainsKey(rawMat))
                    {
                        materials.Add(rawMat, 0);
                    }

                    materials[rawMat] += quantity;

                    //check if some of the legenderies is collected
                    obtainedElement = CheckForLegendaryElement(materials);

                    if (obtainedElement != "")
                    {
                        Console.WriteLine($"{obtainedElement} obtained!");
                        break;
                    }

                }

                if (obtainedElement != "")
                {
                    break;
                }
                count++;

            }

            printOutput(materials);
        }

        private static void printOutput(Dictionary<string, long> materials)
        {
            var rareItems = materials.Take(3).OrderByDescending(x => x.Value).ThenBy(x=>x.Key).ToList();
            var junkItems = materials.Skip(3).OrderBy(x => x.Key).ToList();


            foreach (var rareItem in rareItems)
            {
                Console.WriteLine($"{rareItem.Key}: {rareItem.Value}");
            }


            foreach (var item in junkItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }

        private static string CheckForLegendaryElement(Dictionary<string, long> materials)
        {
            string Element = "";
            if (materials["fragments"] >= 250)
            {
                Element = "Valanyr";
                materials["fragments"] -= 250;
            }

            if (materials["shards"] >= 250)
            {
                Element = "Shadowmourne";
                materials["shards"] -= 250;
            }

            if (materials["motes"] >= 250)
            {
                Element = "Dragonwrath";
                materials["motes"] -= 250;
            }

            return Element;
        }
    }
}
