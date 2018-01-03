using System;
using System.Linq;

namespace CountOccurrencesOfLargerNumbersInArray
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double p = double.Parse(Console.ReadLine());

            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                if (currentNumber > p)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
