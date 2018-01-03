using System;
using System.Linq;

namespace _01.ArrayContainsElement
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
