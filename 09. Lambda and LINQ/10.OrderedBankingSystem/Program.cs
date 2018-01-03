using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.OrderedBankingSystem
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var bankingSystem = new Dictionary<string, Dictionary<string, decimal>>();

            while (inputLine != "end")
            {
                var elements = inputLine.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var bank = elements[0];
                var account = elements[1];
                var balance = decimal.Parse(elements[2]);

                if (!bankingSystem.ContainsKey(bank))
                {
                    bankingSystem[bank] = new Dictionary<string, decimal>();
                }
                if (!bankingSystem[bank].ContainsKey(account))
                {
                    bankingSystem[bank][account] = 0;
                }
                bankingSystem[bank][account] += balance;

                inputLine = Console.ReadLine();
            }

            bankingSystem = bankingSystem
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToDictionary(bank => bank.Key, bank => bank.Value
                    .OrderByDescending(account => account.Value)
                    .ToDictionary(account => account.Key, account => account.Value));

            foreach (var bankAccountPair in bankingSystem)
            {
                foreach (var accountBalancePair in bankAccountPair.Value)
                {
                    Console.WriteLine($"{accountBalancePair.Key} -> {accountBalancePair.Value} ({bankAccountPair.Key})");
                }
            }
        }
    }
}
