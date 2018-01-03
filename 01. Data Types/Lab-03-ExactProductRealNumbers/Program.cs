using System;

namespace ExactProductOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal product = 1;

            for (int i = 0; i < n; i++)
            {
                product *= decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(product);
        }
    }
}
