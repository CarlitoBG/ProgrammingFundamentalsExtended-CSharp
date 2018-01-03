using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        public static void Main()
        {
            var pattern = @"\+359(-| )2{1}\1\d{3}\1\d{4}\b";
            var regex = new Regex(pattern);

            var text = Console.ReadLine();

            var matches = regex.Matches(text);

            for (int i = 0; i < matches.Count - 1; i++)
            {
                Console.Write(matches[i] + ", ");
            }

            Console.Write(matches[matches.Count - 1]);
            Console.WriteLine();
        }
    }
}