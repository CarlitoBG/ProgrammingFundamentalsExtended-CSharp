using System;
using System.Text.RegularExpressions;

namespace _04.WinningTicket
{
    class Program
    {
        public static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var winningTicketPattern = @"([@#$^])\1{5,}";

                    var leftHalf = ticket.Substring(0, ticket.Length / 2);
                    var rightHalf = ticket.Substring(ticket.Length / 2);

                    var leftHalfMatch = Regex.Match(leftHalf, winningTicketPattern);
                    var rightHalfMatch = Regex.Match(rightHalf, winningTicketPattern);

                    if (leftHalfMatch.Success && rightHalfMatch.Success)
                    {
                        var shorterMatch = Math.Min(leftHalfMatch.Length, rightHalfMatch.Length);

                        var jackpot = string.Empty;

                        if (shorterMatch == 10)
                        {
                            jackpot = " Jackpot!";
                        }

                        Console.WriteLine($"ticket \"{ticket}\" - {shorterMatch}{leftHalfMatch.Value[0]}{jackpot}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}