using System;
using System.Linq;

namespace ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers[i])
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
