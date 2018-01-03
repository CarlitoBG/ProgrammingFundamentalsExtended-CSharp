using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.LINQuistics
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var collectionAndMethods = new Dictionary<string, HashSet<string>>();

            while (inputLine != "exit")
            {
                var elements = inputLine.Split(".()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var collection = elements[0];

                if (elements.Length > 1)
                {                   
                    if (!collectionAndMethods.ContainsKey(collection))
                    {
                        collectionAndMethods[collection] = new HashSet<string>();
                    }

                    for (int i = 1; i < elements.Length; i++)
                    {
                        collectionAndMethods[collection].Add(elements[i]);
                    }
                }
                else
                {
                    var number = 0;

                    if (int.TryParse(elements[0], out number) && collectionAndMethods.Count > 0)
                    {
                        var orderedMethods = collectionAndMethods.Values
                            .OrderByDescending(x => x.Count())
                            .First()
                            .OrderBy(x => x.Length)
                            .Take(number);

                        foreach (var methodName in orderedMethods)
                        {
                            Console.WriteLine($"* {methodName}");
                        }
                    }
                    else if (collectionAndMethods.ContainsKey(collection))
                    {
                        var orderedMethods = collectionAndMethods[collection]
                            .OrderByDescending(x => x.Length)
                            .ThenByDescending(x => x.Distinct().Count())
                            .ToList();

                        foreach (var methodName in orderedMethods)
                        {
                            Console.WriteLine($"* {methodName}");
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            var lastLine = Console.ReadLine().Split();
            var method = lastLine[0];
            var selection = lastLine[1];

            var orderedCollections = collectionAndMethods
                    .Where(x => x.Value.Contains(method))
                    .OrderByDescending(x => x.Value.Count())
                    .ThenByDescending(x => x.Value.Min(y => y.Length));

            if (selection == "all")
            {
                foreach (var collection in orderedCollections)
                {
                    Console.WriteLine(collection.Key);

                    foreach (var methodName in collection.Value.OrderByDescending(x => x.Count()))
                    {
                        Console.WriteLine($"* {methodName}");
                    }
                }
            }
            else
            {
                foreach (var collection in orderedCollections)
                {
                    Console.WriteLine(collection.Key);
                }
            }
        }
    }
}
