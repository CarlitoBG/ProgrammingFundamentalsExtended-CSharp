using System;
using System.Linq;

namespace _06.RectanglePosition
{
    class Program
    {
        public static void Main()
        {
            var firstRect = ReadRectangle();
            var secondRect = ReadRectangle();

            var result = firstRect.IsInside(secondRect);

            var printResult = result ? "Inside" : "Not inside";

            Console.WriteLine(printResult);
        }

        public static Rectangle ReadRectangle()
        {
            var rectangleParts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            return new Rectangle()
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Width = rectangleParts[2],
                Height = rectangleParts[3]
            };
        }
    }
}
