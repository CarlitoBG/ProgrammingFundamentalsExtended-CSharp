using System;
using System.Text.RegularExpressions;

namespace _07.HappinessIndex
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var emoticonsPattern = @"((?<happy>[;:][)D*\]}]|[\(*c[][;:])|(?<sad>[;:][c([{]|[D\])][;:]))";

            var matches = Regex.Matches(input, emoticonsPattern);

            var happyCount = 0;
            var sadCount = 0;

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    var happy = match.Groups["happy"];
                    var sad = match.Groups["sad"];

                    if (happy.Success)
                    {
                        happyCount++;
                    }
                    else if (sad.Success)
                    {
                        sadCount++;
                    }
                }
            }

            var happinessIndex = happyCount / (double)sadCount;
            var happinessScore = string.Empty;

            if (happinessIndex >= 2)
            {
                happinessScore = ":D";
            }
            else if (happinessIndex > 1)
            {
                happinessScore = ":)";
            }
            else if (happinessIndex == 1)
            {
                happinessScore = ":|";
            }
            else if (happinessIndex < 1)
            {
                happinessScore = ":(";
            }

            Console.WriteLine($"Happiness index: {happinessIndex:f2} {happinessScore}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}