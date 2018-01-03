using System;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var capacity = 4 + 8 + 12;
            var courses = (int)Math.Ceiling((double)n / capacity);

            Console.WriteLine(courses);
        }
    }
}
