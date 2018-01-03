using System;
using System.Collections.Generic;

namespace _03.RecordUniqueNames
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var names = Console.ReadLine();
                set.Add(names);
            }

            Console.WriteLine(string.Join(Environment.NewLine, set));
        }
    }
}
