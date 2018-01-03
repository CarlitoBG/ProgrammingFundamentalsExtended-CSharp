using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                var currentNumber = num;
                var sum = 0;

                foreach (var symbol in currentNumber.ToString())
                {
                    var digit = symbol - '0';
                    sum += digit;
                }

                var result = (sum == 5 || sum == 7 || sum == 11);

                Console.WriteLine($"{num} -> {result}");
            }
        }
    }
}
