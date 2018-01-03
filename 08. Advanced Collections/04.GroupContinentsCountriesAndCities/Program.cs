using System;
using System.Collections.Generic;

namespace _04.GroupContinentsCountriesAndCities
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                if (!data.ContainsKey(continent))
                {
                    data[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!data[continent].ContainsKey(country))
                {
                    data[continent][country] = new SortedSet<string>();
                }

                data[continent][country].Add(city);
            }

            foreach (var continentCountries in data)
            {
                var continents = continentCountries.Key;
                var countries = continentCountries.Value;
                Console.WriteLine($"{continents}:");

                foreach (var countryCities in countries)
                {
                    var countryName = countryCities.Key;
                    var city = countryCities.Value;
                    Console.WriteLine($"  {countryName} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}
