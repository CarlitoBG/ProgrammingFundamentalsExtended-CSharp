using System;

namespace CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            var count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                if (currentWord.Length == 1)
                {
                    char character = currentWord[0];

                    if (character >= 'A' && character <= 'Z')
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
