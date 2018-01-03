using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08.Commits
{
    public class Commit
    {
        public string Hash { get; set; }

        public string Message { get; set; }

        public int Additions { get; set; }

        public int Deletions { get; set; }

        public Commit(string hash, string message, int additions, int deletions)
        {
            Hash = hash;
            Message = message;
            Additions = additions;
            Deletions = deletions;
        }

    }

    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var urlPattern = @"^https:\/\/github.com\/([A-Za-z0-9\-]+)\/([A-Za-z\-_]+)\/commit\/([0-9a-f]{40}),([^\n]*),([0-9]*),([0-9]*)$";
           
            var usersRepos = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            while (inputLine != "git push")
            {
                var match = Regex.Match(inputLine, urlPattern);

                if (match.Success)
                {
                    var user = match.Groups[1].Value;
                    var repo = match.Groups[2].Value;
                    var hash = match.Groups[3].Value;
                    var message = match.Groups[4].Value;
                    var additions = int.Parse(match.Groups[5].Value);
                    var deletions = int.Parse(match.Groups[6].Value);
                    
                    if (!usersRepos.ContainsKey(user))
                    {
                        usersRepos[user] = new SortedDictionary<string, List<Commit>>();
                    }
                    if (!usersRepos[user].ContainsKey(repo))
                    {
                        usersRepos[user][repo] = new List<Commit>();
                    }

                    var commit = new Commit(hash, message, additions, deletions);

                    usersRepos[user][repo].Add(commit);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var user in usersRepos)
            {
                Console.WriteLine($"{user.Key}:");

                foreach (var repo in usersRepos[user.Key])
                {
                    Console.WriteLine($"{repo.Key}:");

                    var totalAdditionsCount = 0;
                    var totalDeletionsCount = 0;

                    foreach (var commit in repo.Value)
                    {
                        Console.WriteLine($"    commit {commit.Hash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");

                        totalAdditionsCount += commit.Additions;
                        totalDeletionsCount += commit.Deletions;
                    }

                    Console.WriteLine($"    Total: {totalAdditionsCount} additions, {totalDeletionsCount} deletions");
                }
            }
        }
    }
}