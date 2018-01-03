using System;
using System.Collections.Generic;

namespace _07.ForumTopics
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var topicTags = new Dictionary<string, HashSet<string>>();

            while (inputLine != "filter")
            {
                var elements = inputLine.Split(new[] {' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var topic = elements[0];

                if (!topicTags.ContainsKey(topic))
                {
                    topicTags[topic] = new HashSet<string>();
                }

                for (int i = 1; i < elements.Length; i++)
                {
                    topicTags[topic].Add(elements[i]);
                }

                inputLine = Console.ReadLine();
            }

            var tags = Console.ReadLine();
            var tagsElements = tags.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var topicAndTags in topicTags)
            {
                var contains = false;

                for (int i = 0; i < tagsElements.Length; i++)
                {
                    if (topicAndTags.Value.Contains(tagsElements[i]))
                    {
                        contains = true;
                    }
                    else
                    {
                        contains = false;
                        break;
                    }
                }

                if (contains)
                {
                    Console.WriteLine($"{topicAndTags.Key} | #{string.Join(", #", topicAndTags.Value)}");
                }
            }
        }
    }
}
