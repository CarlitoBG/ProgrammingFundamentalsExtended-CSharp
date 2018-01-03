using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.GUnit
{
    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var validInputPattern = @"^([A-Z][A-Za-z0-9]+) \| ([A-Z][A-Za-z0-9]+) \| ([A-Z][A-Za-z0-9]+)$";

            var database = new Dictionary<string, Dictionary<string, List<string>>>();

            while (inputLine != "It's testing time!")
            {
                if (Regex.IsMatch(inputLine, validInputPattern))
                {
                    var match = Regex.Match(inputLine, validInputPattern);

                    var className = match.Groups[1].Value;
                    var methodName = match.Groups[2].Value;
                    var unitTestName = match.Groups[3].Value;

                    if (!database.ContainsKey(className))
                    {
                        database[className] = new Dictionary<string, List<string>>();
                    }

                    if (!database[className].ContainsKey(methodName))
                    {
                        database[className][methodName] = new List<string>();
                    }

                    if (!database[className][methodName].Contains(unitTestName))
                    {
                        database[className][methodName].Add(unitTestName);
                    }
                }

                inputLine = Console.ReadLine();
            }

            database = database
                .OrderByDescending(x => x.Value.Values.Sum(unitTests => unitTests.Count))
                .ThenBy(x => x.Value.Count)
                .ThenBy(x => x.Key, StringComparer.Ordinal)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var className in database)
            {
                Console.WriteLine($"{className.Key}:");

                var sortedMethods = className.Value
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key, StringComparer.Ordinal)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var method in sortedMethods)
                {
                    Console.WriteLine($"##{method.Key}");

                    var sortedUnitTests = method.Value
                        .OrderBy(x => x.Length)
                        .ThenBy(x => x, StringComparer.Ordinal)
                        .ToList();

                    foreach (var unitTest in sortedUnitTests)
                    {
                        Console.WriteLine($"####{unitTest}");
                    }
                }
            }
        }
    }
}