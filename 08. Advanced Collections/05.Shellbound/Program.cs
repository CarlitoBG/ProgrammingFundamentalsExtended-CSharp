using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Shellbound
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var shellRegions = new Dictionary<string, HashSet<int>>();

            while (inputLine != "Aggregate")
            {
                var elements = inputLine.Split(' ');
                var region = elements[0];
                var size = int.Parse(elements[1]);

                if (!shellRegions.ContainsKey(region))
                {
                    shellRegions[region] = new HashSet<int>();
                }
                shellRegions[region].Add(size);              

                inputLine = Console.ReadLine();
            }

            foreach (var regionSizes in shellRegions)
            {
                var region = regionSizes.Key;
                var sizes = regionSizes.Value;
                
                var giantShell = (sizes.Sum() - (sizes.Sum() / sizes.Count));

                Console.WriteLine($"{region} -> {string.Join(", ", sizes)} ({giantShell})");
            }
        }
    }
}
