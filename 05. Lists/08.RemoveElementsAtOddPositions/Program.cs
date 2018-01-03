using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveElementsAtOddPositions
{
    class Program
    {
        static void Main()
        {
            var elements = Console.ReadLine().Split(' ').ToList();

            var result = new List<string>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(elements[i]);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
