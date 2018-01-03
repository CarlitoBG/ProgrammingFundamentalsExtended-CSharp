using System;
using System.Linq;

namespace _15.IntegerInsertion
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var indexOfList = int.Parse(line[0].ToString());

                numbers.Insert(indexOfList, int.Parse(line));

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
