using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.RageQuit
{
    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().ToUpper();

            var pattern = @"(\D+)(\d+)";
            var matches = Regex.Matches(inputLine, pattern);

            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                for (int i = 0; i < int.Parse(match.Groups[2].Value); i++)
                {
                    result.Append(match.Groups[1].Value);
                }
            }

            var uniqueSymbolCount = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbolCount}");
            Console.WriteLine(result);
        }
    }
}