using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.OptimizedBankingSystem
{
    class BankAccount
    {
        public string Name { get; set; }

        public string Bank { get; set; }

        public decimal Balance { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var account = new List<BankAccount>();

            while (inputLine != "end")
            {
                var elements = inputLine.Split("| ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var bank = elements[0];
                var accountName = elements[1];
                var accountBalance = decimal.Parse(elements[2]);

                var newAccount = new BankAccount();

                newAccount.Bank = bank;
                newAccount.Name = accountName;
                newAccount.Balance = accountBalance;

                account.Add(newAccount);

                inputLine = Console.ReadLine();
            }

            var orderedAccounts = account
                .OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length)
                .ToList();

            foreach (var orderedAccount in orderedAccounts)
            {
                Console.WriteLine($"{orderedAccount.Name} -> {orderedAccount.Balance} ({orderedAccount.Bank})");
            }
        }
    }
}
