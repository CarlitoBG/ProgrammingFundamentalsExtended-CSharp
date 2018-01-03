using System;
using System.Linq;

namespace _02.Largest3Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var largest3Nums = numbers.OrderByDescending(n => n).Take(3);

            Console.WriteLine(string.Join(" ", largest3Nums)); 
        }
    }
}
