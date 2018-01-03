using System;
using System.Linq;

namespace _02.Ladybugs
{
    public class Program
    {
        public static void Main()
        {
            var sizeOfField = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var field = new int[sizeOfField];

            foreach (var ladybugIndex in ladybugIndexes)
            {
                if (ladybugIndex >= 0 && ladybugIndex < sizeOfField)
                {
                    field[ladybugIndex] = 1;
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }

                var currentLadybugIndex = int.Parse(command[0]);
                var direction = command[1];
                var flyLength = int.Parse(command[2]);

                if (currentLadybugIndex < 0 || currentLadybugIndex >= sizeOfField || field[currentLadybugIndex] == 0)
                {
                    continue;
                }

                field[currentLadybugIndex] = 0;

                while (true)
                {
                    if (direction == "right")
                    {
                        currentLadybugIndex += flyLength;
                    }
                    else
                    {
                        currentLadybugIndex -= flyLength;
                    }

                    if (currentLadybugIndex < 0 || currentLadybugIndex >= sizeOfField)
                    {
                        break;
                    }

                    if (field[currentLadybugIndex] == 0)
                    {
                        field[currentLadybugIndex] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}