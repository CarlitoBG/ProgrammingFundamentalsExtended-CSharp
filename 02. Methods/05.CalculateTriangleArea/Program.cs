using System;

namespace _05.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(width, height);

            Console.WriteLine(area);
        }

        static double GetTriangleArea(double width, double height)
        {
            double triangleArea = width * height / 2;
            return triangleArea; 
        }
    }
}
