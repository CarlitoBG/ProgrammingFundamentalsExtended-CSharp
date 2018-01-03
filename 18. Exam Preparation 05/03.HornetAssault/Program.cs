using System;
using System.Linq;

namespace _03.HornetAssault
{
    public class Program
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                var hornetSummedPower = hornets.Sum();

                if (hornets.Count != 0)
                {
                    if (beehives[i] >= hornetSummedPower)
                    {
                        hornets.RemoveAt(0);
                    }

                    beehives[i] -= hornetSummedPower;
                }
            }

            if (beehives.Any(x => x > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}