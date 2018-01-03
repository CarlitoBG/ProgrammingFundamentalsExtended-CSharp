using System;

namespace LargestElementInArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int largestNumber = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber > largestNumber)
                {
                    largestNumber = currentNumber;
                }
            }

            Console.WriteLine(largestNumber);
        }
    }
}
