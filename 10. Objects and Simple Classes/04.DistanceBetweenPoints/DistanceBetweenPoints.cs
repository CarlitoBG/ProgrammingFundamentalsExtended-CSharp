using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        public static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");
        }

        public static double CalcDistance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }

        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Point()
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }
    }
}
