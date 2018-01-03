using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OlympicsAreComing
{
    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var countryAthletes = new Dictionary<string, List<string>>();

            while (inputLine != "report")
            {
                var inputParams = inputLine.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                var athlete = inputParams[0].Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var country = inputParams[1].Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                var athleteName = string.Join(" ", athlete);
                var countryName = string.Join(" ", country);

                if (!countryAthletes.ContainsKey(countryName))
                {
                    countryAthletes[countryName] = new List<string>();
                }

                countryAthletes[countryName].Add(athleteName);

                inputLine = Console.ReadLine();
            }

            countryAthletes = countryAthletes
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var country in countryAthletes)
            {
                var numberOfUniqueAthletes = country.Value.Distinct().Count();

                Console.WriteLine($"{country.Key} ({numberOfUniqueAthletes} participants): {country.Value.Count} wins");
            }
        }
    }
}