using System;

namespace _01.Wormtest
{
    public class Program
    {
        public static void Main()
        {
            var wormLengthInMeters = int.Parse(Console.ReadLine());
            var wormWidthInCentimeters = double.Parse(Console.ReadLine());

            var wormLengthInCentimeters = wormLengthInMeters * 100;
            var remainder = wormLengthInCentimeters % wormWidthInCentimeters;

            if (remainder == 0 || double.IsNaN(remainder))
            {
                var result = wormLengthInCentimeters * wormWidthInCentimeters;
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                var result = (wormLengthInCentimeters / wormWidthInCentimeters) * 100;
                Console.WriteLine($"{result:f2}%");
            }
        }
    }
}