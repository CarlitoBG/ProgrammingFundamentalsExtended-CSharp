using System;
using System.Linq;

namespace CountOfGivenElementInArray
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                if (currentNumber == n)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
