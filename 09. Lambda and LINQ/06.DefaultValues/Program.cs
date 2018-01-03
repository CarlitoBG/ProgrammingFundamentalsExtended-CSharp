using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.DefaultValues
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var defaultValues = new Dictionary<string, string>();

            while (inputLine != "end")
            {
                var input = inputLine.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var inputKey = input[0];
                var inputValue = input[1];

                defaultValues[inputKey] = inputValue;

                inputLine = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            var unchangedValues = defaultValues
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            var changedValues = defaultValues
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var kvp in unchangedValues)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }

            foreach (var kvp in changedValues)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
        }
    }
}
