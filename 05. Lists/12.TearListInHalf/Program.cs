using System;
using System.Collections.Generic;
using System.Linq;

namespace TearListInHalf
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var leftSide = new List<int>();
            var rightSide = new List<int>();
            var result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                leftSide.Add(numbers[i]);
            }

            for (int i = numbers.Count / 2; i <= numbers.Count - 1; i++)
            {
                rightSide.Add(numbers[i]);
            }

            for (int i = 0; i < leftSide.Count; i++)
            {
                result.Add(rightSide[i] / 10);
                result.Add(leftSide[i]);
                result.Add(rightSide[i] % 10);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
