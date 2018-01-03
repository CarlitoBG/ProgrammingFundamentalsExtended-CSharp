using System;
using System.Linq;

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < secondLine.Count; i++)
            {
                for (int j = 0; j < firstLine.Count; j++)
                {
                    if (firstLine[j] == secondLine[i])
                    {
                        secondLine.Remove(secondLine[i]);
                        i--;
                        break;
                    }
                }
            }
      
            var sum1 = firstLine.Sum();
            var sum2 = secondLine.Sum();

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum1}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
