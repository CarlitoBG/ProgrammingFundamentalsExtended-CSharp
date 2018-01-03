using System;
using System.Linq;

namespace _04.FoldAndSum
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = numbers.Length / 4;

            var firstPartUpperRow = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            var secondPartUpperRow = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            var upperRow = firstPartUpperRow.Concat(secondPartUpperRow).ToArray();

            var lowerRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var result = upperRow.Select((n, index) => n + lowerRow[index]);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
