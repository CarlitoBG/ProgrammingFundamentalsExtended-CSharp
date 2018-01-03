using System;
using System.Linq;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var randomPosition = random.Next(0, words.Length);

                var tempWord = words[randomPosition];
                words[randomPosition] = words[i];
                words[i] = tempWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
