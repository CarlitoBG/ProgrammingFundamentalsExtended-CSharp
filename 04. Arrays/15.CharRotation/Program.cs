using System;
using System.Linq;

namespace CharRotation
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += (char)(input[i] - numbers[i]);
                }
                else
                {
                    result += (char)(input[i] + numbers[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
