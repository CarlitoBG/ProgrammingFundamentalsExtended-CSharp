using System;

namespace _08.SentenceSplit
{
    class Program
    {
        public static void Main()
        {
            var sentence = Console.ReadLine();
            var delimiter = Console.ReadLine();

            var result = sentence.Split(new[] { delimiter }, StringSplitOptions.None);

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}