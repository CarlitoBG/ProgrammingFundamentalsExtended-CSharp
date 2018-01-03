using System;

namespace _01.SplinterTrip
{
    public class Program
    {
        public static void Main()
        {
            var tripDistance = double.Parse(Console.ReadLine());
            var fuelTankCapacity = double.Parse(Console.ReadLine());
            var milesSpentInHeavyWinds = double.Parse(Console.ReadLine());

            var fuelConsumptionPerMile = 25;
            var fuelConsumptionInHeavyWinds = 25 * 1.5;

            var milesInNonHeavyWinds = tripDistance - milesSpentInHeavyWinds;
            var nonHeavyWindsConsumption = milesInNonHeavyWinds * fuelConsumptionPerMile;
            var heavyWindsConsumption = milesSpentInHeavyWinds * fuelConsumptionInHeavyWinds;
            var fuelConsumption = nonHeavyWindsConsumption + heavyWindsConsumption;
            var tolerance = fuelConsumption * (5 / 100d);
            var totalFuelConsumption = fuelConsumption + tolerance;

            var remainingFuel = Math.Abs(fuelTankCapacity - totalFuelConsumption);

            if (fuelTankCapacity >= totalFuelConsumption)
            {
                Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");
                Console.WriteLine($"Enough with {remainingFuel:f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");
                Console.WriteLine($"We need {remainingFuel:f2}L more fuel.");
            }
        }
    }
}