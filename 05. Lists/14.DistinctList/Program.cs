using System;
using System.Linq;

namespace _14.DistinctList
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbers.RemoveAt(j);
                        i--;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
