using System;
using System.Linq;

namespace _09.AverageCharacterDelimiter
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var sumOfCharacters = 0;
            var countOfLetters = 0;

            foreach (var word in input)
            {
                foreach (var letter in word)
                {
                    sumOfCharacters += letter;
                    countOfLetters++;
                }
            }

            var delimiter = (char)(sumOfCharacters / countOfLetters);
            var upperDelimiter = delimiter.ToString().ToUpper();

            Console.WriteLine(string.Join($"{upperDelimiter}", input));
        }
    }
}
