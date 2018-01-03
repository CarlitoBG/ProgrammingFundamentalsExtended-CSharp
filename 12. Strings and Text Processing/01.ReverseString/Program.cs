using System;
using System.Text;

namespace _01.ReverseString
{
    class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
