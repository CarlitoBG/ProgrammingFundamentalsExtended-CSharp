using System;
using System.Linq;

namespace EqualSequenceOfElementsInArray
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool areAllEqual = true;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] != numbers[i + 1])
                {
                    areAllEqual = false;
                    break;
                }
            }

            if (areAllEqual)
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
