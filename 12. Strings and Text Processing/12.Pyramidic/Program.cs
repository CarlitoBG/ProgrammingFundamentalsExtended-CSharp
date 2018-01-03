using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Pyramidic
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var lines = new string[n];
            var pyramids = new List<string>();

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int line = 0; line < lines.Length; line++)
            {
                var currentLine = lines[line];

                for (int charIndex = 0; charIndex < currentLine.Length; charIndex++)
                {
                    var currentChar = currentLine[charIndex];
                    var layer = 1;
                    var currentPyramid = string.Empty;

                    for (int lineIndex = line; lineIndex < lines.Length; lineIndex++)
                    {
                        var currentLayer = new string(currentChar, layer);

                        if (lines[lineIndex].Contains(currentLayer))
                        {
                            currentPyramid += currentLayer + "\r\n";
                        }
                        else
                        {
                            break;
                        }

                        layer += 2;
                    }

                    pyramids.Add(currentPyramid.Trim());
                }
            }

            Console.WriteLine(pyramids.OrderByDescending(x => x.Length).First());
        }
    }
}