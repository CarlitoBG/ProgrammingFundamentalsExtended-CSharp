using System;
using System.Collections.Generic;

namespace _08.ShootListElements
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();

            int lastRemoved = -1;
            string output = string.Empty;

            while (input != "stop")
            {
                if (input == "bang")
                {
                    if (numbers.Count == 0)
                    {
                        output = "nobody left to shoot! last one was {0}";
                        break;
                    }

                    int sum = SumNumbers(numbers);
                    double average = (double)sum / numbers.Count;

                    lastRemoved = ShootElements(numbers, average);
                    DecrementElements(numbers);
                }
                else
                {
                    int number = int.Parse(input);
                    numbers.Insert(0, number);
                }

                input = Console.ReadLine();
            }

            if (numbers.Count > 0 && output == string.Empty)
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
            }
            else if (numbers.Count == 0 && output == string.Empty)
            {
                Console.WriteLine("you shot them all. last one was {0}", lastRemoved);
            }
            else
            {
                Console.WriteLine(output, lastRemoved);
            }
        }

        static void DecrementElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

        static int ShootElements(List<int> numbers, double average)
        {
            int result = -1;

            if (numbers.Count == 1)
            {
                Console.WriteLine($"shot {numbers[0]}");
                result = numbers[0];
                numbers.RemoveAt(0);
                return result;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < average)
                {
                    Console.WriteLine($"shot {numbers[i]}");
                    result = numbers[i];
                    numbers.RemoveAt(i);
                    break;
                }
            }

            return result;
        }

        static int SumNumbers(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
