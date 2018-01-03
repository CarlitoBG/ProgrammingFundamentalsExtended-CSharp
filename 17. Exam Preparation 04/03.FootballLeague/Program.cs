using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.FootballLeague
{
    public class Score
    {
        public decimal Points { get; set; }

        public decimal Goals { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var key = Regex.Escape(Console.ReadLine());
            var inputLine = Console.ReadLine();

            var pattern = $@"^.*(?:{key})(?<team1>[A-Za-z]*)(?:{key}).* .*(?:{key})(?<team2>[A-Za-z]*)(?:{key}).* (?<team1Score>\d+):(?<team2Score>\d+).*$";

            var teamScores = new Dictionary<string, Score>();

            while (inputLine != "final")
            {
                var match = Regex.Match(inputLine, pattern);

                var team1Name = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                var team2Name = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                var team1Goals = int.Parse(match.Groups["team1Score"].Value);
                var team2Goals = int.Parse(match.Groups["team2Score"].Value);

                if (!teamScores.ContainsKey(team1Name))
                {
                    teamScores[team1Name] = new Score();
                }

                if (!teamScores.ContainsKey(team2Name))
                {
                    teamScores[team2Name] = new Score();
                }

                if (team1Goals > team2Goals)
                {
                    teamScores[team1Name].Points += 3;
                }
                else if (team1Goals == team2Goals)
                {
                    teamScores[team1Name].Points++;
                    teamScores[team2Name].Points++;
                }
                else
                {
                    teamScores[team2Name].Points += 3;
                }

                teamScores[team1Name].Goals += team1Goals;
                teamScores[team2Name].Goals += team2Goals;

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            var leagueStandings = teamScores.OrderByDescending(x => x.Value.Points).ThenBy(x => x.Key);

            var place = 1;
            foreach (var leagueStanding in leagueStandings)
            {
                var teamName = leagueStanding.Key;
                var teamPoints = leagueStanding.Value.Points;

                Console.WriteLine($"{place++}. {teamName} {teamPoints}");
            }

            Console.WriteLine("Top 3 scored goals:");

            var top3Goals = teamScores
                .OrderByDescending(x => x.Value.Goals).ThenBy(x => x.Key).Take(3);

            foreach (var teamGoals in top3Goals)
            {
                var teamName = teamGoals.Key;
                var goals = teamGoals.Value.Goals;

                Console.WriteLine($"- {teamName} -> {goals}");
            }
        }
    }
}