using System;
using System.Linq;

namespace BallisticsTraining
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split(' ');

            int x = 0;
            int y = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "right")
                {
                    x += int.Parse(commands[i + 1]);
                }
                else if (commands[i] == "left")
                {
                    x -= int.Parse(commands[i + 1]);
                }
                else if (commands[i] == "up")
                {
                    y += int.Parse(commands[i + 1]);
                }
                else if (commands[i] == "down")
                {
                    y -= int.Parse(commands[i + 1]);
                }
            }

            if (x == numbers[0] && y == numbers[1])
            {
                Console.WriteLine($"firing at [{x}, {y}]");
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine($"firing at [{x}, {y}]");
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
