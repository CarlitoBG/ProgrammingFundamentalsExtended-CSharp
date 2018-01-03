using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05.RegisterUsers
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var registry = new Dictionary<string, DateTime>();

            while (inputLine != "end")
            {
                var input = inputLine.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var username = input[0];
                var date = DateTime.ParseExact(input[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                registry.Add(username, date);

                inputLine = Console.ReadLine();
            }

            var result = registry
                .Reverse()
                .OrderBy(d => d.Value)
                .Take(5)
                .OrderByDescending(d => d.Value);

            foreach (var data in result)
            {
                Console.WriteLine(data.Key);
            }
        }
    }
}
