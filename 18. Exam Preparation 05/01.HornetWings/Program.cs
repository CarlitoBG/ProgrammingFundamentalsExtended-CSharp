using System;

namespace _01.HornetWings
{
    public class Program
    {
        public static void Main()
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distanceFor1000WingFlaps = double.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var hornetRestTime = 5;
            var flapsPerSecond = 100;
            var flyTime = wingFlaps / flapsPerSecond;
            var restTime = (wingFlaps / endurance) * hornetRestTime;

            var metersTraveled = (wingFlaps / 1000) * distanceFor1000WingFlaps;
            var secondsPassed = flyTime + restTime;

            Console.WriteLine($"{metersTraveled:f2} m.");
            Console.WriteLine($"{secondsPassed} s.");
        }
    }
}