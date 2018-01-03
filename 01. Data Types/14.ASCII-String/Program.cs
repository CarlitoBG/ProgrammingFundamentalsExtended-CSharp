using System;

namespace _14.ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < number; i++)
            {
                int asciiCode = int.Parse(Console.ReadLine());
                char character = (char) asciiCode;
                result += character;
            }

            Console.WriteLine(result);
        }
    }
}
