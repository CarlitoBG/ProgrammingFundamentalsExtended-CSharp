using System;
using System.Linq;

namespace _17.UnunionLists
{
    class Program
    {
        static void Main()
        {
            var primalList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int lineIndex = 0; lineIndex < line.Count; lineIndex++)
                {
                    if (primalList.Contains(line[lineIndex]))
                    {
                        primalList.RemoveAll(number => number == line[lineIndex]);
                    }
                    else
                    {
                        primalList.Add(line[lineIndex]);
                    }
                }
            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
