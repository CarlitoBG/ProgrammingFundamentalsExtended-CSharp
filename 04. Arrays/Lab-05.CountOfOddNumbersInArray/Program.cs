using System;
using System.Linq;

namespace _05.CountOfOddNumbersInArray
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1 || numbers[i] % 2 == -1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
