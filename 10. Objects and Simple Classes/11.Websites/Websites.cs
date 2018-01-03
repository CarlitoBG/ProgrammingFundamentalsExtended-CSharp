using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Websites
{
    class Website
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public List<string> Queries { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var websites = new List<Website>();

            while (inputLine != "end")
            {
                var elements = inputLine.Split("| ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var host = elements[0];
                var domain = elements[1];
                var queries = elements.Skip(2).ToList();

                var newWebsite = new Website();

                newWebsite.Host = host;
                newWebsite.Domain = domain;
                newWebsite.Queries = queries;

                websites.Add(newWebsite);

                inputLine = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                if (website.Queries.Count > 0)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?=[{string.Join("]&[", website.Queries)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
            }
        }
    }
}
