using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04.Cards
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = "([1]?[0-9JQKA])([SHDC])";
            var matches = Regex.Matches(input, pattern);

            var result = new List<string>();

            foreach (Match match in matches)
            {
                int power = 0;

                if (int.TryParse(match.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }

                result.Add(match.Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}