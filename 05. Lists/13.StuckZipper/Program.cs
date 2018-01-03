using System;
using System.Collections.Generic;
using System.Linq;

namespace StuckZipper
{
    class Program
    {
        static void Main()
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            var smallestAmountOfDigits = FindSmallestAmountOfDigits(firstList, secondList);

            RemoveNumbersWithMoreDigits(firstList, smallestAmountOfDigits);
            RemoveNumbersWithMoreDigits(secondList, smallestAmountOfDigits);

            var insertionIndex = 1;

            for (int i = 0; i < firstList.Count; i++)
            {
                secondList.Insert(Math.Min(insertionIndex, secondList.Count), firstList[i]);
                insertionIndex += 2;
            }

            Console.WriteLine(string.Join(" ", secondList));
        }

        private static void RemoveNumbersWithMoreDigits(List<int> list, int smallestAmountOfDigits)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var currentNumber = NumberOfDigits(list[i]);

                if (currentNumber > smallestAmountOfDigits)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        private static int FindSmallestAmountOfDigits(List<int> firstList, List<int> secondList)
        {
            var smallestAmountOfDigits = int.MaxValue;

            foreach (var number in firstList)
            {
                var numberOfDigits = NumberOfDigits(number);

                if (numberOfDigits < smallestAmountOfDigits)
                {
                    smallestAmountOfDigits = numberOfDigits;
                }
            }

            foreach (var number in secondList)
            {
                var numberOfDigits = NumberOfDigits(number);

                if (numberOfDigits < smallestAmountOfDigits)
                {
                    smallestAmountOfDigits = numberOfDigits;
                }
            }

            return smallestAmountOfDigits;
        }

        static int NumberOfDigits(int number)
        {
            number = Math.Abs(number);

            var numberOfDigits = 0;

            while (number > 0)
            {
                numberOfDigits++;
                number /= 10;
            }

            return numberOfDigits;
        }
    }
}