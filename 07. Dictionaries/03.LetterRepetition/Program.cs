using System;
using System.Collections.Generic;

namespace _03.LetterRepetition
{
    class Program
    {
        static void Main()
        {
            var characters = Console.ReadLine();

            var result = new Dictionary<char, int>();

            foreach (var character in characters)
            {
                if (!result.ContainsKey(character))
                {
                    result[character] = 0;
                }

                result[character]++;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
