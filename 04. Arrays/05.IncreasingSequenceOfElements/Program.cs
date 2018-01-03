using System;
using System.Linq;

namespace IncreasingSequenceOfElements
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool areAllBigger = true;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] >= numbers[i + 1])
                {
                    areAllBigger = false;
                    break;
                }
            }

            if (areAllBigger)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
