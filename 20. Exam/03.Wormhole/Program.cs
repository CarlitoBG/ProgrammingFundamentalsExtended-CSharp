using System;
using System.Linq;

namespace _03.Wormhole
{
    public class Program
    {
        public static void Main()
        {
            var wormholes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var steps = 0;

            for (int i = 0; i < wormholes.Length; i++)
            {
                if (wormholes[i] == 0)
                {
                    steps++;
                }
                else
                {
                    var index = wormholes[i];
                    wormholes[i] = 0;
                    i = index - 1;
                }
            }

            Console.WriteLine(steps);
        }
    }
}