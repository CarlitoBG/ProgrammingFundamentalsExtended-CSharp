using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").ToLower().Split();
            var text = File.ReadAllText("text.txt").ToLower().Split(new char[]
            {'\n', 'r', ' ', '.', ',', '!', '?', '-'}, StringSplitOptions.RemoveEmptyEntries);

            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordCount[word] = 0;
            }

            foreach (var word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            wordCount = wordCount.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var wordCountPair in wordCount)
            {
                File.AppendAllText("output.txt", $"{wordCountPair.Key} - {wordCountPair.Value}" + Environment.NewLine);
            }
        }
    }
}
