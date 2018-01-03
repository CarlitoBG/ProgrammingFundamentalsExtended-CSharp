using System;

namespace NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int digit = FindNthDigit(number, index);

            Console.WriteLine(digit);
        }

        static int FindNthDigit(long number, int index)
        {
            int currentIndex = 1;

            while (number > 0)
            {
                if (currentIndex == index)
                {
                    return (int)(number % 10);
                }

                currentIndex++;
                number /= 10;
            }

            return (int)(number % 10); ;        
        }
    }
}
