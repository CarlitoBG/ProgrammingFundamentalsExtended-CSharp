using System;
using System.Collections.Generic;

namespace _06.Dict_Ref_Advanced
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var dictRef = new Dictionary<string, List<int>>();

            while (inputLine != "end")
            {
                var elements = inputLine.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var currentKey = elements[0];
                var firstValue = 0;

                if (int.TryParse(elements[1], out firstValue))
                {
                    if (!dictRef.ContainsKey(currentKey))
                    {
                        dictRef[currentKey] = new List<int>();
                    }

                    for (int i = 1; i < elements.Length; i++)
                    {
                        dictRef[currentKey].Add(int.Parse(elements[i]));
                    }
                }
                else
                {
                    var otherKey = elements[1];

                    if (dictRef.ContainsKey(otherKey))
                    {
                        dictRef[currentKey] = new List<int>(dictRef[otherKey]);
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var entry in dictRef)
            {
                Console.WriteLine($"{entry.Key} === {string.Join(", ", entry.Value)}");
            }
        }
    }
}
