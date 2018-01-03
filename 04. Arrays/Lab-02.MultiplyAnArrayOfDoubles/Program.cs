using System;
using System.Linq;

namespace _02.MultiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
            }

            var result = string.Join(" ", numbers);

            Console.WriteLine(result);
        }
    }
}
