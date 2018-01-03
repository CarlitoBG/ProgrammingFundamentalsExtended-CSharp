using System;
using System.Linq;

namespace _14.RabbitHole
{
    class Program
    {
        static void Main()
        {
            var commands = Console.ReadLine().Split(' ').ToList();
            var energy = int.Parse(Console.ReadLine());

            var currentIndex = 0;
            bool lastBomb = false;

            while (energy > 0)
            {
                var commandElements = commands[currentIndex].Split('|');
                var currentCommand = commandElements[0];
                lastBomb = false;

                if (currentCommand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }

                var value = int.Parse(commandElements[1]);

                switch (currentCommand)
                {
                    case "Left":
                        currentIndex = Math.Abs(currentIndex - value) % commands.Count;
                        energy -= value;
                        break;
                    case "Right":
                        currentIndex = (currentIndex + value) % commands.Count;
                        energy -= value;
                        break;
                    case "Bomb":
                        commands.RemoveAt(currentIndex);
                        currentIndex = 0;
                        energy -= value;
                        lastBomb = true;
                        break;
                }

                if (commands[commands.Count - 1] != "RabbitHole")
                {
                    commands.RemoveAt(commands.Count - 1);
                }
                
                commands.Add("Bomb|" + energy);
            }

            if (energy <= 0 && lastBomb)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            else if (energy <= 0 && !lastBomb)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
        }
    }
}
