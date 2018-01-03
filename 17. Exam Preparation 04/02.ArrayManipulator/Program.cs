using System;
using System.Linq;

namespace _02.ArrayManipulator
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var command = Console.ReadLine();

            while (command != "end")
            {
                var commandParams = command.Split();
                var manipulationCommand = commandParams[0];

                switch (manipulationCommand)
                {
                    case "exchange":
                        var index = int.Parse(commandParams[1]);

                        array = Exchange(array, index);
                        break;
                    case "max":
                    case "min":
                        var maxOrMin = manipulationCommand;
                        var evenOrOdd = commandParams[1];

                        FindMaxOrMinEvenOrOdd(array, maxOrMin, evenOrOdd);
                        break;
                    case "first":
                    case "last":
                        var firstOrLast = manipulationCommand;
                        var count = int.Parse(commandParams[1]);
                        evenOrOdd = commandParams[2];

                        FindFirstOrLastEvenOrOdd(array, firstOrLast, count, evenOrOdd);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static void FindFirstOrLastEvenOrOdd(int[] array, string firstOrLast, int count, string evenOrOdd)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            var evenOrOddParity = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElements = array.Where(x => x % 2 == evenOrOddParity).ToArray();

            int[] foundElements;

            if (firstOrLast == "first")
            {
                foundElements = evenOrOddElements.Take(count).ToArray();
            }
            else
            {
                foundElements = evenOrOddElements.Reverse().Take(count).Reverse().ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", foundElements)}]");
        }

        private static void FindMaxOrMinEvenOrOdd(int[] array, string maxOrMin, string evenOrOdd)
        {
            var evenOrOddParity = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElements = array.Where(x => x % 2 == evenOrOddParity).ToArray();

            if (!evenOrOddElements.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var maxOrMinElement = maxOrMin == "max" ? evenOrOddElements.Max() : evenOrOddElements.Min();
            var maxOrMinElementIndex = Array.LastIndexOf(array, maxOrMinElement);

            Console.WriteLine(maxOrMinElementIndex);
        }

        private static int[] Exchange(int[] array, int index)
        {
            if (!(index >= 0 && index < array.Length))
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            var leftPart = array.Take(index + 1);
            var rightPart = array.Skip(index + 1);

            var exchangedArray = rightPart.Concat(leftPart).ToArray();
            return exchangedArray;
        }
    }
}