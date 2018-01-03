using System;
using System.Text.RegularExpressions;

namespace _04.CubicMessages
{
    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var pattern = @"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]+)?$";

            while (inputLine != "Over!")
            {
                var match = Regex.Match(inputLine, pattern);

                if (match.Success)
                {
                    var message = match.Groups["message"].Value;

                    var number = int.Parse(Console.ReadLine());

                    if (message.Length == number)
                    {
                        var leftPart = match.Groups["leftPart"].Value;
                        var rightPart = match.Groups["rightPart"].Value;

                        var verificationCode = string.Empty;
                        var verificationIndexes = leftPart + rightPart;

                        foreach (var character in verificationIndexes)
                        {
                            int index;
                            var isDigit = int.TryParse(character.ToString(), out index);
                            var isValid = index >= 0 && index < message.Length;

                            if (isDigit && isValid)
                            {
                                var messageChar = message[index];
                                verificationCode += messageChar;
                            }
                            else
                            {
                                verificationCode += " ";
                            }
                        }

                        Console.WriteLine($"{message} == {verificationCode}");
                    }
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}