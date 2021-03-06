﻿using System;
using System.Linq;

namespace _02.SmallestElementInArray
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var smallestNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
