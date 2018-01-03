using System;
using System.Text.RegularExpressions;

namespace _03.ReplaceATag
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var pattern = @"<a.*?href.*?=(.*?)>(.*?)<\/a>";
                var replace = @"[URL href=$1]$2[/URL]";
                var replaced = Regex.Replace(input, pattern, replace);

                Console.WriteLine(replaced);

                input = Console.ReadLine();
            }
        }
    }
}