using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.DecodeRadioFrequencies
{
    class Program
    {
        static void Main()
        {
            var frequencies = Console.ReadLine().Split(' ').ToArray();

            var output = new List<char>();

            for (int i = 0; i < frequencies.Length; i++)
            {
                var frequency = frequencies[i].Split('.').ToArray();

                var leftPart = (char)(int.Parse(frequency[0]));
                var rightPart = (char)(int.Parse(frequency[1]));
                
                if (leftPart != 0)
                {
                    output.Insert(i, leftPart);
                }

                if (rightPart != 0)
                {
                    output.Insert(output.Count - i, rightPart);
                }
            }

            Console.WriteLine(string.Join("", output));
        }
    }
}
