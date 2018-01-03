using System;
using System.Linq;

namespace _15.JapaneseRoulette
{
    class Program
    {
        static void Main()
        {
            var cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var players = Console.ReadLine().Split(' ').ToArray();

            var initialPosition = 0;
            var endPosition = 0;
            bool dead = false;

            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == 1)
                {
                    initialPosition = i;
                    break;
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                dead = false;
                var currentCommand = players[i].Split(',');
                var strength = int.Parse(currentCommand[0]);
                var direction = currentCommand[1];

                switch (direction)
                {
                    case "Right":
                        endPosition = (initialPosition + strength) % cylinder.Length;
                        initialPosition = endPosition;
                        break;
                    case "Left":
                        endPosition = (initialPosition - strength) % cylinder.Length;

                        if (endPosition < 0)
                        {
                            endPosition += cylinder.Length;
                        }

                        initialPosition = endPosition;
                        break;
                }

                if (endPosition == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    dead = true;
                    break;
                }

                initialPosition++;
            }

            if (!dead)
            {
                Console.WriteLine($"Everybody got lucky!");
            }
        }
    }
}
