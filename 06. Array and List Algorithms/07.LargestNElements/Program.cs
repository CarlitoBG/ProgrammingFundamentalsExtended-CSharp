using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.LargestNElements
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());

            var largestNElements = new List<int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var firstUnsorted = i + 1;

                while (firstUnsorted > 0)
                {
                    if (numbers[firstUnsorted] > numbers[firstUnsorted - 1])
                    {
                        var temp = numbers[firstUnsorted];
                        numbers[firstUnsorted] = numbers[firstUnsorted - 1];
                        numbers[firstUnsorted - 1] = temp;
                    }

                    firstUnsorted--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                largestNElements.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(" ", largestNElements));
        }
    }
}
