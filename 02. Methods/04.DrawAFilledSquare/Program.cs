using System;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintFilledSquare(n);
        }

        static void PrintFilledSquare(int n)
        {
            PrintHeaderRow(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRows(n);
            }

            PrintHeaderRow(n);
        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintMiddleRows(int n)
        {
            Console.Write("-");

            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }
    }
}
