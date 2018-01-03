using System;
using System.Collections.Generic;
using System.Linq;

namespace FlipListSides
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var reversedNumbers = new List<int>();

            for (int i = 1; i < numbers.Count - 1; i++)
            {
                reversedNumbers.Add(numbers[i]);
            }

            reversedNumbers.Reverse();

            Console.Write(numbers[0] + " ");
            Console.Write(string.Join(" ", reversedNumbers));
            Console.WriteLine(" " + numbers[numbers.Count - 1]);
        }
    }
}
