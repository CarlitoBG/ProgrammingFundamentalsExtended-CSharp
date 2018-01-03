using System;

namespace MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int smallerNumberOfTwo = GetMin(a, b);
            int smallerNumberOfThree = GetMin(smallerNumberOfTwo, c);

            Console.WriteLine(smallerNumberOfThree);
        }

        static int GetMin(int a, int b)
        {
            int smaller = Math.Min(a, b);           

            return smaller;
        }
    }
}
