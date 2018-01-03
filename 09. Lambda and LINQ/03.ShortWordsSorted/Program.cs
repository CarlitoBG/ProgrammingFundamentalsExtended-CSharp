using System;
using System.Linq;

namespace _03.ShortWordsSorted
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine()
                .Split(".,:;()[]\"'/\\!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .Select(w => w.ToLower())
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
