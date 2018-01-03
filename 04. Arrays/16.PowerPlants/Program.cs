using System;
using System.Linq;

namespace PowerPlants
{
    class Program
    {
        static void Main()
        {
            int[] powerLevel = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int daysSurvived = 0;
            int seasons = 0;

            while (powerLevel.Max() != 0)
            {
                for (int days = 0; days < powerLevel.Length; days++)
                {
                    for (int plantIndex = 0; plantIndex < powerLevel.Length; plantIndex++)
                    {
                        if (days != plantIndex && powerLevel[plantIndex] > 0)
                        {
                            powerLevel[plantIndex]--;
                        }
                    }

                    daysSurvived++;

                    if (powerLevel.Max() == 0)
                    {
                        break;
                    }
                }

                if (powerLevel.Max() == 0)
                {
                    break;
                }

                for (int plantIndex = 0; plantIndex < powerLevel.Length; plantIndex++)
                {
                    if (powerLevel[plantIndex] > 0)
                    {
                        powerLevel[plantIndex]++;
                    }
                }

                seasons++;
            }

            Console.WriteLine($"survived {daysSurvived} days ({seasons} seasons)");
        }
    }
}
