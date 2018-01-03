using System;
using System.Globalization;

namespace _01.SinoTheWalker
{
    public class Program
    {
        public static void Main()
        {
            var leaveTime = TimeSpan
                .ParseExact(Console.ReadLine(), "hh\\:mm\\:ss", CultureInfo.InvariantCulture);
            var numberOfSteps = int.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());

            var secondsInADay = 60 * 60 * 24;
            var timeToHomeInSeconds = TimeSpan
                .FromSeconds((numberOfSteps % secondsInADay) * (secondsPerStep % secondsInADay));

            var arrivalTime = leaveTime.Add(timeToHomeInSeconds);

            Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", arrivalTime);
        }
    }
}