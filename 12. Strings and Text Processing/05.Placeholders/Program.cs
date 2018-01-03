using System;

namespace _05.Placeholders
{
    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var sentenceParams = inputLine
                    .Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                var sentence = sentenceParams[0];
                var values = sentenceParams[1]
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < values.Length; i++)
                {
                    var placeholder = "{" + i + "}";
                    sentence = sentence.Replace(placeholder, values[i]);
                }

                Console.WriteLine(sentence);

                inputLine = Console.ReadLine();
            }
        }
    }
}