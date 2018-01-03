using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.WordEncounter
{
    class Program
    {
        public static void Main()
        {
            var filter = Console.ReadLine();
            var sentence = Console.ReadLine();

            char filterCharacter = filter[0];
            var filterDigit = int.Parse(filter[1].ToString());

            var validWords = new List<string>();

            while (sentence != "end")
            {
                var validSentencePattern = @"^[A-Z].*[.?!]$";
                var matchSentence = Regex.IsMatch(sentence, validSentencePattern);

                if (matchSentence)
                {
                    var wordPattern = @"\w+";
                    var matchWords = Regex.Matches(sentence, wordPattern);

                    foreach (Match word in matchWords)
                    {
                        var characterCount = 0;

                        foreach (var character in word.Groups[0].Value)
                        {
                            if (character == filterCharacter)
                            {
                                characterCount++;
                            }
                        }

                        if (characterCount >= filterDigit)
                        {
                            validWords.Add(word.Groups[0].Value);
                        }
                    }
                }

                sentence = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", validWords));
        }
    }
}