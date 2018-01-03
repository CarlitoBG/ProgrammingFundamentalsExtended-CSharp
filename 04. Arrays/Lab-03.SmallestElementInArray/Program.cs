using System;
using System.Linq;

namespace _03.SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int smallestNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                if (currentNumber < smallestNumber)
                {
                    smallestNumber = currentNumber;
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
