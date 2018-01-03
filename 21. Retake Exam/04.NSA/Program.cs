using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.NSA
{
    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var registry = new Dictionary<string, Dictionary<string, long>>();

            while (inputLine != "quit")
            {
                var inputParams = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var countryName = inputParams[0];
                var spyName = inputParams[1];
                var daysInService = long.Parse(inputParams[2]);

                if (!registry.ContainsKey(countryName))
                {
                    registry[countryName] = new Dictionary<string, long>();
                }

                if (!registry[countryName].ContainsKey(spyName))
                {
                    registry[countryName][spyName] = 0L;
                }

                registry[countryName][spyName] = daysInService;

                inputLine = Console.ReadLine();
            }

            var orderedCountries = registry
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var country in orderedCountries)
            {
                Console.WriteLine($"Country: {country.Key}");

                var orderedSpies = country.Value
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var spy in orderedSpies)
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}