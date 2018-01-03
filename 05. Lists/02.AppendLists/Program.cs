using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('|');

            var result = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int[] numbers = input[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                result.AddRange(numbers);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
