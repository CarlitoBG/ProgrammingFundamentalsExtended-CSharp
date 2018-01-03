using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.FlattenDictionary
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (inputLine != "end")
            {
                var elements = inputLine.Split(' ');

                if (elements[0] != "flatten")
                {
                    var key = elements[0];
                    var innerKey = elements[1];
                    var innerValue = elements[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }
                    dictionary[key][innerKey] = innerValue;
                }
                else
                {
                    var flattenKey = elements[1];
                    dictionary[flattenKey] = dictionary[flattenKey]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                inputLine = Console.ReadLine();
            }

            var orderedDictionary = dictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderedDictionary)
            {
                Console.WriteLine($"{kvp.Key}");

                var innerDictionary = kvp.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenedValues = kvp.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                var count = 1;

                foreach (var innerKvp in innerDictionary)
                {
                    Console.WriteLine($"{count}. {innerKvp.Key} - {innerKvp.Value}");
                    count++;
                }

                foreach (var flattenedValue in flattenedValues)
                {
                    Console.WriteLine($"{count}. {flattenedValue.Key}");
                    count++;
                }
            }
        }
    }
}
