using System;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = n; i > 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
