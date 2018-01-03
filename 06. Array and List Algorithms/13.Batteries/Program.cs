using System;
using System.Linq;

namespace _13.Batteries
{
    class Program
    {
        static void Main()
        {
            var batteryCapacity = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var testHours = int.Parse(Console.ReadLine());

            for (int i = 0; i < batteryCapacity.Length; i++)
            {
                var batteryStatus = batteryCapacity[i] - (usagePerHour[i] * testHours);
                var capacityPercentage = (batteryStatus * 100) / batteryCapacity[i];

                if (batteryStatus > 0)
                {
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", i + 1, batteryStatus, capacityPercentage);
                }
                else
                {
                    var lasted = (int)Math.Ceiling(batteryCapacity[i] / usagePerHour[i]);
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", i + 1, lasted);
                }
            }           
        }
    }
}
