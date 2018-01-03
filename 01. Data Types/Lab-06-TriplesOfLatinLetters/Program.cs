using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i1 = 0; i1 < n; i1++)
            {
                for (int i2 = 0; i2 < n; i2++)
                {
                    for (int i3 = 0; i3 < n; i3++)
                    {
                        var letter1 = (char)(i1 + 'a');
                        var letter2 = (char)(i2 + 'a');
                        var letter3 = (char)(i3 + 'a');

                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }
        }
    }
}
