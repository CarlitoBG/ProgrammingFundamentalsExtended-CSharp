using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.NetherRealms
{
    public class Program
    {
        public static void Main()
        {
            var demonsName = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var sortedDemons = new SortedDictionary<string, List<double>>();

            var healthPattern = @"[^0-9+\-\*/.]";
            var damagePattern = @"-?\d+\.?\d*";

            foreach (var demonName in demonsName)
            {
                var healthSymbols = Regex.Matches(demonName, healthPattern);
                var health = 0;

                foreach (Match healthSymbol in healthSymbols)
                {
                    health += char.Parse(healthSymbol.Value);
                }

                var damageSymbols = Regex.Matches(demonName, damagePattern);
                var damage = 0.0;

                foreach (Match damageSymbol in damageSymbols)
                {
                    damage += double.Parse(damageSymbol.Value);
                }

                foreach (var symbol in demonName)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }

                    if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }

                sortedDemons[demonName] = new List<double>() { health, damage };
            }

            foreach (var demon in sortedDemons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }
    }
}