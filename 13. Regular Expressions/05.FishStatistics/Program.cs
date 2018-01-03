using System;
using System.Text.RegularExpressions;

namespace _05.FishStatistics
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"(>*)<(\(+)(['\-x])>";
            var matches = Regex.Matches(input, pattern);

            var fishCount = 1;

            if (matches.Count != 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine($"Fish {fishCount}: {match.Groups[0]}");

                    TailType(match);
                    BodyType(match);
                    Status(match);

                    fishCount++;
                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }
        }

        private static void Status(Match match)
        {
            var status = match.Groups[3].ToString();

            if (status == "'")
            {
                Console.WriteLine("  Status: Awake");
            }
            else if (status == "-")
            {
                Console.WriteLine("  Status: Asleep");
            }
            else if (status == "x")
            {
                Console.WriteLine("  Status: Dead");
            }
        }

        private static void BodyType(Match match)
        {
            var bodyLength = match.Groups[2].Length;

            if (bodyLength > 10)
            {
                Console.WriteLine("  Body type: Long ({0} cm)", bodyLength * 2);
            }
            else if (bodyLength > 5 && bodyLength <= 10)
            {
                Console.WriteLine("  Body type: Medium ({0} cm)", bodyLength * 2);
            }
            else
            {
                Console.WriteLine("  Body type: Short ({0} cm)", bodyLength * 2);
            }
        }

        private static void TailType(Match match)
        {
            var tailLength = match.Groups[1].Length;

            if (tailLength > 5)
            {
                Console.WriteLine("  Tail type: Long ({0} cm)", tailLength * 2);
            }
            else if (tailLength > 1 && tailLength <= 5)
            {
                Console.WriteLine("  Tail type: Medium ({0} cm)", tailLength * 2);
            }
            else if (tailLength == 1)
            {
                Console.WriteLine("  Tail type: Short ({0} cm)", tailLength * 2);
            }
            else
            {
                Console.WriteLine("  Tail type: None");
            }
        }
    }
}