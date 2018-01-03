using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniKaraoke
{
    public class Program
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            var songs = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.None).ToList();
            var stagePerformance = Console.ReadLine();

            var allParticipants = new Dictionary<string, SortedSet<string>>();

            while (stagePerformance != "dawn")
            {
                var stagePerformanceParams = stagePerformance
                    .Split(new[] { ", " }, StringSplitOptions.None);

                var participant = stagePerformanceParams[0];
                var song = stagePerformanceParams[1];
                var award = stagePerformanceParams[2];

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!allParticipants.ContainsKey(participant))
                    {
                        allParticipants[participant] = new SortedSet<string>();
                    }

                    allParticipants[participant].Add(award);
                }

                stagePerformance = Console.ReadLine();
            }

            if (!allParticipants.Any())
            {
                Console.WriteLine("No awards");
            }

            foreach (var participant in allParticipants.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                foreach (var award in participant.Value)
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}