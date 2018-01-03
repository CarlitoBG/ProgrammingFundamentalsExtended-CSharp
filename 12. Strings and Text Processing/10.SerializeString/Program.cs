using System;
using System.Collections.Generic;

namespace _10.SerializeString
{
    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var characters = new HashSet<char>();

            foreach (var character in inputLine)
            {
                characters.Add(character);
            }

            var result = string.Empty;

            foreach (var character in characters)
            {
                result += character + ":";
                var index = inputLine.IndexOf(character, 0);

                while (index != -1)
                {
                    result += index + "/";
                    index = inputLine.IndexOf(character, index + 1);
                }

                Console.WriteLine(result.TrimEnd('/'));
                result = string.Empty;
            }
        }
    }
}