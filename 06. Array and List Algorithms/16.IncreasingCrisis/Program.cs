using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.IncreasingCrisis
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                InsertNumbers(numbers);
                RemoveNumbers(numbers);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void RemoveNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    for (int removed = i + 1; removed < numbers.Count; removed++)
                    {
                        numbers.RemoveAt(removed);
                        removed--;
                    }
                }
            }
        }

        public static void InsertNumbers(List<int> numbers)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            var empty = numbers.Count == 0 || numbers[numbers.Count - 1] <= sequence[0];

            if (empty)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    numbers.Add(sequence[i]);
                }
            }
            else
            {
                var positionStart = PositionStart(numbers, sequence);
                var positionEnd = positionStart + sequence.Count;
                var count = 0;

                for (int i = positionStart; i < positionEnd; i++)
                {
                    numbers.Insert(i, sequence[count]);
                    count++;

                    if (numbers[i] > numbers[i + 1])
                    {
                        break;
                    }
                }
            }
        }

        public static int PositionStart(List<int> numbers, List<int> sequence)
        {
            var positionStart = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > sequence[0])
                {
                    positionStart = i;
                    break;
                }
            }

            return positionStart;
        }
    }
}
