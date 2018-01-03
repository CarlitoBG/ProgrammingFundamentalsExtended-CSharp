using System;

namespace _13.Nilapdromes
{
    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var borders = string.Empty;
            var core = string.Empty;

            while (inputLine != "end")
            {
                for (int i = (inputLine.Length - 1) / 2; i > 0; i--)
                {
                    if (inputLine.Substring(0, i) == inputLine.Substring(inputLine.Length - i, i))
                    {
                        borders = inputLine.Substring(0, i);
                        core = inputLine.Substring(i, (inputLine.Length - (i * 2)));

                        Console.WriteLine(core + borders + core);
                        break;
                    }
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}