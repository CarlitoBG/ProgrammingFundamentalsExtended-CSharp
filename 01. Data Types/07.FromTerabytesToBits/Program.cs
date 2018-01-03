using System;

namespace _07.FromTerabytesToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            long terabytes = 8796093022208;
            double bits = number * terabytes;

            Console.WriteLine(bits);
        }
    }
}
