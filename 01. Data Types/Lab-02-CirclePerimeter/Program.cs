using System;

namespace CirclePerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", 2 * Math.PI * r);
        }
    }
}
