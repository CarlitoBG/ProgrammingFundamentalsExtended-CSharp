using System;
using System.Linq;

namespace _10.SortArrayOfStrings
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i].CompareTo(input[i + 1]) == 1)
                    {
                        var temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;

                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
