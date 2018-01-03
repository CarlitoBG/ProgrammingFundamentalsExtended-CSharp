using System;

namespace StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string stringRepeater = RepeatString(str, count);

            Console.WriteLine(stringRepeater);
        }

        static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += str; 
            }

            return repeatedString;
        }
    }
}
