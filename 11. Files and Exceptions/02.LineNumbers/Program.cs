using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        public static void Main()
        {
            var text = File.ReadAllLines("Input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("output.txt", $"{i + 1}. {text[i] + Environment.NewLine}");
            }
        }
    }
}
