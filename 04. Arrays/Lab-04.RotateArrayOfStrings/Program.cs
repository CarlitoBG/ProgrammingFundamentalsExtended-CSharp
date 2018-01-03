using System;
using System.Linq;

namespace _04.RotateArrayOfStrings
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            var rotatedArray = new string[words.Length];

            rotatedArray[0] = words[words.Length - 1];

            for (int i = 0; i < words.Length - 1; i++)
            {
                rotatedArray[i + 1] = words[i];
            }

            var result = string.Join(" ", rotatedArray);

            Console.WriteLine(result);
        }
    }
}
