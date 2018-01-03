using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CottageScraper
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var treeHeight = new Dictionary<string, List<int>>();

            while (inputLine != "chop chop")
            {
                var elements = inputLine.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var tree = elements[0];
                var height = int.Parse(elements[1]);

                if (!treeHeight.ContainsKey(tree))
                {
                    treeHeight[tree] = new List<int>();
                }
                treeHeight[tree].Add(height);

                inputLine = Console.ReadLine();
            }

            var typeOfTree = Console.ReadLine();
            var minLengthPerTree = int.Parse(Console.ReadLine());

            var pricePerMeter = Math.Round(treeHeight.SelectMany(x => x.Value).Sum()
                / (double)treeHeight.SelectMany(x => x.Value).Count(), 2);
            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");

            var usedLogs = treeHeight
                .Where(x => x.Key == typeOfTree)
                .SelectMany(x => x.Value)
                .Where(x => x >= minLengthPerTree)
                .Sum();

            var usedLogsPrice = Math.Round(usedLogs * pricePerMeter, 2);
            Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");

            var unusedLogs = treeHeight
                .Where(x => x.Key != typeOfTree)
                .SelectMany(x => x.Value)
                .Sum();

            var unusedSmallerLogs = treeHeight
                .Where(x => x.Key == typeOfTree)
                .SelectMany(x => x.Value)
                .Where(x => x < minLengthPerTree)
                .Sum();

            var unusedLogsPrice = Math.Round(((unusedLogs + unusedSmallerLogs) * pricePerMeter * 0.25), 2);
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");

            var cottageScraperSubtotal = usedLogsPrice + unusedLogsPrice;
            Console.WriteLine($"CottageScraper subtotal: ${cottageScraperSubtotal:f2}");
        }
    }
}
