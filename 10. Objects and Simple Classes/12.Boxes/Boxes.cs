using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Boxes
{
    class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public double Width
        {
            get
            {
                return Point.CalculateDistance(UpperLeft, UpperRight);
            }
        }

        public double Height
        {
            get
            {
                return Point.CalculateDistance(UpperLeft, BottomLeft);
            }
        }

        public int CalculatePerimeter(int width, int height)
        {
            var perimeter = (2 * width + 2 * height);

            return perimeter; 
        }

        public int CalculateArea(int width, int height)
        {
            var area = width * height;

            return area;
        }

    }

    class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public static double CalculateDistance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }
    }

    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var boxes = new List<Box>();

            while (inputLine != "end")
            {
                var elements = inputLine
                    .Split(":| ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                var newBox = new Box
                {
                    UpperLeft = new Point
                    {
                        X = elements[0],
                        Y = elements[1]
                    },
                    UpperRight = new Point
                    {
                        X = elements[2],
                        Y = elements[3]
                    },
                    BottomLeft = new Point
                    {
                        X = elements[4],
                        Y = elements[5]
                    },
                    BottomRight = new Point
                    {
                        X = elements[6],
                        Y = elements[7]
                    },
                };

                boxes.Add(newBox);

                inputLine = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {box.CalculatePerimeter((int)box.Width, (int)box.Height)}");
                Console.WriteLine($"Area: {box.CalculateArea((int)box.Width, (int)box.Height)}");
            }
        }
    }
}
