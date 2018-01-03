using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            var result = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result[number] = 0;
                }

                result[number]++;
            }

            foreach (var kvp in result)
            {
                var timeString = kvp.Value == 1 ? "time" : "times";
                Console.WriteLine($"{kvp.Key} -> {kvp.Value} {timeString}");
            }
        }
    }
}
