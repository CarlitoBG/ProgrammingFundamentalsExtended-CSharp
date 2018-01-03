using System;
using System.Collections.Generic;

namespace _02.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split(' ');
                var continent = elements[0];
                var country = elements[1];
                var city = elements[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new Dictionary<string, List<string>>();
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new List<string>();
                }

                continentsData[continent][country].Add(city);
            }

            foreach (var continentCountries in continentsData)
            {
                var continentName = continentCountries.Key;
                var countries = continentCountries.Value;

                Console.WriteLine($"{continentName}:");

                foreach (var countryCities in countries)
                {
                    var countryName = countryCities.Key;
                    var cities = countryCities.Value;
                    Console.WriteLine($"  {countryName} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
