using System;
using System.Linq;

namespace _03.Spyfer
{
    public class Program
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < sequence.Count; i++)
            {
                if (i == 0 && sequence[i] == sequence[i + 1])
                {
                    sequence.RemoveAt(i + 1);
                    i = 0;
                }
                else if (i != 0 && i != sequence.Count - 1 && sequence[i] == sequence[i - 1] + sequence[i + 1])
                {
                    sequence.RemoveAt(i + 1);
                    sequence.RemoveAt(i - 1);
                    i = 0;
                }
                else if (i == sequence.Count - 1 && sequence[i - 1] == sequence[i])
                {
                    sequence.RemoveAt(i - 1);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}