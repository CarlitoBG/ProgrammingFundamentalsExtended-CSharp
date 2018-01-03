using System;
using System.Collections.Generic;

namespace _07.UserLogins
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var userEntries = new Dictionary<string, string>();

            while (input != "login")
            {
                var inputElements = input.Split(' ');
                var username = inputElements[0];
                var password = inputElements[2];

                if (!userEntries.ContainsKey(username))
                {
                    userEntries.Add(username, password);
                }
                else
                {
                    userEntries[username] = password;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            var count = 0;

            while (input != "end")
            {
                var inputElements = input.Split(' ');
                var username = inputElements[0];
                var password = inputElements[2];

                if (userEntries.ContainsKey(username))
                {
                    if (password == userEntries[username])
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                    else if (password != userEntries[username])
                    {
                        Console.WriteLine($"{username}: login failed");
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine($"{username}: login failed");
                    count++;
                }
               
                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
