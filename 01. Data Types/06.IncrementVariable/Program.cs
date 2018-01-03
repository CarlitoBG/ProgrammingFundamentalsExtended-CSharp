using System;

namespace _06.IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 256)
            {
                Console.WriteLine(n);
            }
            else if (n > 255)
            {
                var value = n % 256;
                var times = n / 256;
                
                Console.WriteLine(value);
                Console.WriteLine("Overflowed {0} times", times);
            }
        }
    }
}
