using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _02.CriticalBreakpoint
{
    public class Line
    {
        public BigInteger X1 { get; set; }

        public BigInteger Y1 { get; set; }

        public BigInteger X2 { get; set; }

        public BigInteger Y2 { get; set; }

        public BigInteger CriticalRatio { get; set; }


    }

    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var lines = new List<Line>();

            BigInteger actualCriticalRatio = 0;
            var criticalBreakpointExist = true;

            while (inputLine != "Break it.")
            {
                var lineParams = inputLine.Split().Select(BigInteger.Parse).ToArray();

                var x1 = lineParams[0];
                var y1 = lineParams[1];
                var x2 = lineParams[2];
                var y2 = lineParams[3];
                var criticalRatio = BigInteger.Abs((x2 + y2) - (x1 + y1));

                var currentLine = new Line
                {
                    X1 = x1,

                    Y1 = y1,

                    X2 = x2,

                    Y2 = y2,

                    CriticalRatio = criticalRatio
                };

                lines.Add(currentLine);

                if (currentLine.CriticalRatio != 0 && actualCriticalRatio == 0)
                {
                    actualCriticalRatio = currentLine.CriticalRatio;
                }

                if (currentLine.CriticalRatio != actualCriticalRatio 
                    && currentLine.CriticalRatio != 0)
                {
                    criticalBreakpointExist = false;
                    break;
                }

                inputLine = Console.ReadLine();
            }

            if (criticalBreakpointExist && actualCriticalRatio != 0)
            {
                BigInteger totalRatio = BigInteger.Pow(actualCriticalRatio, lines.Count);

                BigInteger criticalBreakpoint = 0;

                BigInteger.DivRem(totalRatio, lines.Count, out criticalBreakpoint);

                foreach (var line in lines)
                {
                    Console.WriteLine($"Line: [{line.X1}, {line.Y1}, {line.X2}, {line.Y2}]");
                }

                Console.WriteLine($"Critical Breakpoint: {criticalBreakpoint}");
            }
            else
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }
        }
    }
}