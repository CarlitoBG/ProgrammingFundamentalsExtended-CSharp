using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ArrayHistogram
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            var words = new List<string>();
            var occurrencesCount = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (words.Contains(input[i]))
                {
                    int wordIndex = words.IndexOf(input[i]);
                    occurrencesCount[wordIndex]++;
                }
                else
                {
                    words.Add(input[i]);
                    occurrencesCount.Add(1);
                }             
            }

            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < occurrencesCount.Count - 1; i++)
                {
                    if (occurrencesCount[i] < occurrencesCount[i + 1])
                    {
                        var temp = occurrencesCount[i];
                        occurrencesCount[i] = occurrencesCount[i + 1];
                        occurrencesCount[i + 1] = temp;

                        var tempWord = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = tempWord;

                        swapped = true;
                    }
                }
            } while (swapped);

            for (int i = 0; i < words.Count; i++)
            {
                double percentage = (occurrencesCount[i] * 100.0) / input.Length;

                Console.WriteLine("{0} -> {1} times ({2:f2}%)", words[i], occurrencesCount[i], percentage);
            }
        }
    }
}
