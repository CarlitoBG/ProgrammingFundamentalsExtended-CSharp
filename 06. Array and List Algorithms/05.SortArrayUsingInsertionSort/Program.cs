using System;
using System.Linq;

namespace _05.SortArrayUsingInsertionSort
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var firstUnsorted = i + 1;

                while (firstUnsorted > 0)
                {
                    if (numbers[firstUnsorted] < numbers[firstUnsorted - 1])
                    {
                        var temp = numbers[firstUnsorted];
                        numbers[firstUnsorted] = numbers[firstUnsorted - 1];
                        numbers[firstUnsorted - 1] = temp;
                    }

                    firstUnsorted--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}