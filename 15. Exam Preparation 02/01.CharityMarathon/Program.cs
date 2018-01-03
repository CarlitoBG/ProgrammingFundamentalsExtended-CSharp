using System;

namespace _01.CharityMarathon
{
    public class Program
    {
        public static void Main()
        {
            int lengthOfMarathonInDays = int.Parse(Console.ReadLine());
            long numberOfParticipants = long.Parse(Console.ReadLine());
            int averageNumberOfLaps = int.Parse(Console.ReadLine());
            long lengthOfTrack = long.Parse(Console.ReadLine());
            int capacityOfTrack = int.Parse(Console.ReadLine());
            double moneyDonatedPerKilometer = double.Parse(Console.ReadLine());

            int maxRunners = lengthOfMarathonInDays * capacityOfTrack;
            long participants = Math.Min(numberOfParticipants, maxRunners);
            long totalKilometers = (participants * averageNumberOfLaps * lengthOfTrack) / 1000;
            double totalMoney = totalKilometers * moneyDonatedPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}