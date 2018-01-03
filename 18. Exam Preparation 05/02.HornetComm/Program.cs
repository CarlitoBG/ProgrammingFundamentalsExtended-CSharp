using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.HornetComm
{
    public class Program
    {
        public static void Main()
        {
            var messages = new List<string>();
            var broadcasts = new List<string>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "Hornet is Green")
                {
                    break;
                }

                var inputParams = inputLine.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (inputParams.Length != 2)
                {
                    continue;
                }

                var firstQuery = inputParams[0];
                var secondQuery = inputParams[1];

                if (firstQuery.All(char.IsDigit) && secondQuery.All(char.IsLetterOrDigit))
                {
                    var reversedQuery = new string(firstQuery.Reverse().ToArray());

                    messages.Add($"{reversedQuery} -> {secondQuery}");
                }
                else if (firstQuery.All(x => !char.IsDigit(x)) && secondQuery.All(char.IsLetterOrDigit))
                {
                    var decrypted = new StringBuilder();

                    foreach (var symbol in secondQuery)
                    {
                        if (char.IsUpper(symbol))
                        {
                            decrypted.Append(char.ToLower(symbol));
                        }
                        else if (char.IsLower(symbol))
                        {
                            decrypted.Append(char.ToUpper(symbol));
                        }
                        else
                        {
                            decrypted.Append(symbol);
                        }
                    }

                    broadcasts.Add($"{decrypted} -> {firstQuery}");
                }
            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Any() 
                ? string.Join(Environment.NewLine, broadcasts) : "None");

            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Any()
                ? string.Join(Environment.NewLine, messages) : "None");
        }
    }
}