using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.Extremums
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var command = Console.ReadLine();

            var result = new List<int>();

            var minValue = int.MaxValue;
            var maxValue = int.MinValue;
            var sum = 0;

            if (command == "Min")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    var element = numbers[i];
                    var elementAsString = element.ToString();
                    var countOfRotations = 0;

                    while (countOfRotations < elementAsString.Length)
                    {
                        if (element < minValue)
                        {
                            minValue = element;
                        }

                        elementAsString = RotateDigits(elementAsString);
                        element = int.Parse(elementAsString);
                        countOfRotations++;
                    }

                    result.Add(minValue);
                    sum += minValue;
                    minValue = int.MaxValue;
                }
            }

            if (command == "Max")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    var element = numbers[i];
                    var elementAsString = element.ToString();
                    var countOfRotations = 0;

                    while (countOfRotations < elementAsString.Length)
                    {
                        if (element > maxValue)
                        {
                            maxValue = element;
                        }

                        elementAsString = RotateDigits(elementAsString);
                        element = int.Parse(elementAsString);
                        countOfRotations++;
                    }

                    result.Add(maxValue);
                    sum += maxValue;
                    maxValue = int.MinValue;
                }
            }

            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(sum);
        }

        static string RotateDigits(string elementAsString)
        {
            var firstDigit = elementAsString[0];
            return elementAsString.Substring(1) + firstDigit;
        }
    }
}
