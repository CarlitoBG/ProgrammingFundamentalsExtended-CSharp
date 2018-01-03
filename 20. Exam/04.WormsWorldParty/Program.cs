using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.WormsWorldParty
{
    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var wormTeamNameAndScore = new Dictionary<string, Dictionary<string, long>>();

            while (inputLine != "quit")
            {
                var inputParams = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var wormName = inputParams[0];
                var teamName = inputParams[1];
                var wormScore = long.Parse(inputParams[2]);

                if (wormTeamNameAndScore.Any(x => x.Value.ContainsKey(wormName)))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                if (!wormTeamNameAndScore.ContainsKey(teamName))
                {
                    wormTeamNameAndScore[teamName] = new Dictionary<string, long>();
                }

                if (!wormTeamNameAndScore[teamName].ContainsKey(wormName))
                {
                    wormTeamNameAndScore[teamName][wormName] = 0L;
                }

                wormTeamNameAndScore[teamName][wormName] += wormScore;

                inputLine = Console.ReadLine();
            }

            var orderedTeams = wormTeamNameAndScore
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            var number = 1;

            foreach (var team in orderedTeams)
            {
                Console.WriteLine($"{number++}. Team: {team.Key} - {team.Value.Values.Sum()}");

                var orderedWorms = team.Value.OrderByDescending(x => x.Value);

                foreach (var worm in orderedWorms)
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
            }
        }
    }
}