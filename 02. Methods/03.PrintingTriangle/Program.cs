using System;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);           
        }

        static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLine(i);
            }

            for (int i = number - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int end, int start = 1)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
