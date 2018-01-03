using System;

namespace _04.FloatOrInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number % 1 == 0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(Math.Round(number));
            }
        }
    }
}
