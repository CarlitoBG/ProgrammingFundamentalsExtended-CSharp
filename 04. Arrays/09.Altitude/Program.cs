using System;

namespace Altitude
{
    class Program
    {
        static void Main()
        {
            string[] commands = Console.ReadLine().Split(' ');

            double altitude = double.Parse(commands[0]);

            for (int i = 1; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    altitude += double.Parse(commands[i + 1]);
                }
                else if (commands[i] == "down")
                {
                    altitude -= double.Parse(commands[i + 1]);

                    if (altitude <= 0)
                    {
                        break;
                    }
                }
            }

            if (altitude <= 0)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
        }
    }
}
