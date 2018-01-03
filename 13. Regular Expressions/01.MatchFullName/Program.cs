using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        public static void Main()
        {
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var regex = new Regex(pattern);

            var text = Console.ReadLine();

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }

            Console.WriteLine();
        }
    }
}