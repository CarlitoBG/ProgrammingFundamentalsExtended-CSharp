using System;

namespace _03.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var aOldValue = a;
            a = b;
            b = aOldValue;

            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
        }
    }
}
