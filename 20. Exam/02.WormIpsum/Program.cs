using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.WormIpsum
{
    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var sentencePattern = @"^[A-Z][^\.]+\.$";
            var wordsPattern = @"[A-Za-z]+";

            while (inputLine != "Worm Ipsum")
            {
                var isMatch = Regex.IsMatch(inputLine, sentencePattern);

                if (isMatch)
                {
                    var words = Regex.Matches(inputLine, wordsPattern);

                    foreach (Match word in words)
                    {
                        var charCount = new Dictionary<char, int>();

                        foreach (var character in word.ToString())
                        {
                            if (!charCount.ContainsKey(character))
                            {
                                charCount[character] = 0;
                            }

                            charCount[character]++;
                        }

                        charCount = charCount
                            .Where(x => x.Value > 1)
                            .OrderByDescending(x => x.Value)
                            .Take(1)
                            .ToDictionary(x => x.Key, x => x.Value);

                        if (charCount.Any())
                        {
                            foreach (var character in charCount)
                            {
                                var newWord = new string(character.Key, word.Length);

                                inputLine = inputLine.Replace(word.ToString(), newWord);
                            }
                        }
                    }

                    Console.WriteLine(inputLine);
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}