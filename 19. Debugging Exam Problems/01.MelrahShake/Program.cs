using System;

namespace _01.MelrahShake
{
    public class Program
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var inputPattern = Console.ReadLine();

            var firstMatchIndex = inputString.IndexOf(inputPattern);
            var lastMatchIndex = inputString.LastIndexOf(inputPattern);

            while (inputPattern.Length > 0 && firstMatchIndex != -1 && lastMatchIndex != -1)
            {
                inputString = inputString.Remove(lastMatchIndex, inputPattern.Length);
                inputString = inputString.Remove(firstMatchIndex, inputPattern.Length);

                inputPattern = inputPattern.Remove(inputPattern.Length / 2, 1);

                Console.WriteLine("Shaked it.");

                firstMatchIndex = inputString.IndexOf(inputPattern);
                lastMatchIndex = inputString.LastIndexOf(inputPattern);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(inputString);
        }
    }
}