using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.HornetArmada
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var legionActivity = new Dictionary<string, int>();
            var legionSoldierTypeAndCount = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();

                var inputParams = inputLine
                    .Split("=->: ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = int.Parse(inputParams[0]);
                var legionName = inputParams[1];
                var soldierType = inputParams[2];
                var soldierCount = long.Parse(inputParams[3]);

                if (!legionSoldierTypeAndCount.ContainsKey(legionName))
                {
                    legionSoldierTypeAndCount[legionName] = new Dictionary<string, long>();
                }

                if (!legionSoldierTypeAndCount[legionName].ContainsKey(soldierType))
                {
                    legionSoldierTypeAndCount[legionName][soldierType] = 0L;
                }

                legionSoldierTypeAndCount[legionName][soldierType] += soldierCount;

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity[legionName] = lastActivity;
                }

                if (lastActivity > legionActivity[legionName])
                {
                    legionActivity[legionName] = lastActivity;
                }
            }

            var command = Console.ReadLine().Split('\\');

            if (command.Length > 1)
            {
                var activity = int.Parse(command[0]);
                var soldierType = command[1];

                var orderedLegions = legionSoldierTypeAndCount
                    .Where(x => x.Value.ContainsKey(soldierType))
                    .OrderByDescending(x => x.Value[soldierType]);

                foreach (var legion in orderedLegions)
                {
                    var legionName = legion.Key;
                    var soldierCount = legion.Value[soldierType];

                    if (legionActivity[legionName] < activity)
                    {
                        Console.WriteLine($"{legionName} -> {soldierCount}");
                    }
                }
            }
            else
            {
                var soldierType = command[0];

                var orderedLegions = legionActivity.OrderByDescending(x => x.Value);

                foreach (var legion in orderedLegions)
                {
                    var legionName = legion.Key;
                    var lastActivity = legion.Value;

                    if (legionSoldierTypeAndCount[legionName].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{lastActivity} : {legionName}");
                    }
                }
            }
        }
    }
}