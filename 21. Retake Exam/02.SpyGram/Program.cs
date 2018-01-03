using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.SpyGram
{
    public class Program
    {
        public static void Main()
        {
            var privateKey = Console.ReadLine();
            var nonEncryptedMessage = Console.ReadLine();

            var recipientMessages = new Dictionary<string, List<string>>();

            var messagePattern = @"TO: ([A-Z]+); MESSAGE: (.+);";

            while (nonEncryptedMessage != "END")
            {
                var match = Regex.Match(nonEncryptedMessage, messagePattern);

                if (match.Success)
                {
                    var encryptedMessage = new StringBuilder();

                    for (int i = 0; i < nonEncryptedMessage.Length; i++)
                    {
                        var privateKeyCurrentChar = int.Parse(privateKey[i % privateKey.Length].ToString());
                        encryptedMessage.Append((char)(nonEncryptedMessage[i] + privateKeyCurrentChar));
                    }

                    var recipient = match.Groups[1].Value;

                    if (!recipientMessages.ContainsKey(recipient))
                    {
                        recipientMessages[recipient] = new List<string>();
                    }

                    recipientMessages[recipient].Add(encryptedMessage.ToString());
                }

                nonEncryptedMessage = Console.ReadLine();
            }

            foreach (var recipient in recipientMessages.OrderBy(x => x.Key))
            {
                foreach (var message in recipient.Value)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}