using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Palindromes
{
    class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(" ,.?!".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new HashSet<string>();

            foreach (var word in text)
            {
                var sb = new StringBuilder();

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    sb.Append(word[i]);
                }

                var reversedWord = sb.ToString();

                if (reversedWord == word)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }
    }
}