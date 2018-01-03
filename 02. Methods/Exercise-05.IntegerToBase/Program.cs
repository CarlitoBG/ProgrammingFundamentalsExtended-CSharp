using System;

namespace IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            var integerToBase = IntegerToBase(number, toBase);

            Console.WriteLine(integerToBase);
        }

        static string IntegerToBase(int number, int toBase)
        {
            var result = string.Empty;

            while (number > 0)
            {
                var remainder = number % toBase;
                result = remainder + result;
                number = number / toBase;
            }

            return result;
        }
    }
}
