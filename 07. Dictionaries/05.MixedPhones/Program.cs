using System;
using System.Collections.Generic;

namespace _05.MixedPhones
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var phoneNumbers = new SortedDictionary<string, long>();

            while (input != "Over")
            {
                var elements = input.Split(" :".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

                var firstElement = elements[0];
                var secondElement = elements[1];

                long phoneNumber = 0;

                if (long.TryParse(firstElement, out phoneNumber))
                {
                    phoneNumbers[secondElement] = phoneNumber;
                }
                else if (long.TryParse(secondElement, out phoneNumber))
                {
                    phoneNumbers[firstElement] = phoneNumber;
                }

                input = Console.ReadLine();
            }

            foreach (var nameNumberPair in phoneNumbers)
            {
                Console.WriteLine($"{nameNumberPair.Key} -> {nameNumberPair.Value}");
            }
        }
    }
}
