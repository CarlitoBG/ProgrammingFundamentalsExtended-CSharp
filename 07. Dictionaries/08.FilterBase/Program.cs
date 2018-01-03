using System;
using System.Collections.Generic;

namespace _08.FilterBase
{
    class Program
    {
        static void Main()
        {
            var inputLines = Console.ReadLine();

            var nameAge = new Dictionary<string, int>();
            var nameSalary = new Dictionary<string, double>();
            var namePosition = new Dictionary<string, string>();

            while (inputLines != "filter base")
            {
                var elements = inputLines.Split(' ');
                var name = elements[0];
                var secondParameter = elements[2];

                var age = 0;
                var salary = 0d;

                if (int.TryParse(secondParameter, out age))
                {
                    nameAge.Add(name, age);
                }
                else if (double.TryParse(secondParameter, out salary))
                {
                    nameSalary.Add(name, salary);
                }
                else
                {
                    namePosition.Add(name, secondParameter);
                }

                inputLines = Console.ReadLine();
            }

            inputLines = Console.ReadLine();

            switch (inputLines)
            {
                case "Age":
                    foreach (var nameAgePair in nameAge)
                    {
                        Console.WriteLine($"Name: {nameAgePair.Key}");
                        Console.WriteLine($"Age: {nameAgePair.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
                case "Salary":
                    foreach (var nameSalaryPair in nameSalary)
                    {
                        Console.WriteLine($"Name: {nameSalaryPair.Key}");
                        Console.WriteLine($"Salary: {nameSalaryPair.Value:f2}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
                case "Position":
                    foreach (var namePositionPair in namePosition)
                    {
                        Console.WriteLine($"Name: {namePositionPair.Key}");
                        Console.WriteLine($"Position: {namePositionPair.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
            }
        }
    }
}
