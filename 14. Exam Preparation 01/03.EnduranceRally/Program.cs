using System;
using System.Linq;

namespace _03.EnduranceRally
{
    public class Program
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(' ');
            var trackLayout = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var participant in participants)
            {
                double startingFuel = participant[0];

                for (int i = 0; i < trackLayout.Length; i++)
                {
                    if (!checkpoints.Contains(i))
                    {
                        startingFuel -= trackLayout[i];

                        if (startingFuel <= 0)
                        {
                            Console.WriteLine($"{participant} - reached {i}");
                            break;
                        }
                    }
                    else
                    {
                        startingFuel += trackLayout[i];
                    }
                }

                if (startingFuel > 0)
                {
                    Console.WriteLine($"{participant} - fuel left {startingFuel:f2}");
                }
            }
        }
    }
}