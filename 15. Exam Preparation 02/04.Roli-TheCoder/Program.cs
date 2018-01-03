using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Roli_TheCoder
{
    public class Event
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public SortedSet<string> Participants { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var events = new Dictionary<int, Event>();
               
            while (inputLine != "Time for Code")
            {
                var inputParams = inputLine
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var id = int.Parse(inputParams[0]);
                var eventName = inputParams[1];
                var participants = inputParams.Skip(2).ToArray();

                if (eventName[0] == '#')
                {
                    if (!events.ContainsKey(id))
                    {
                        events[id] = new Event
                        {
                            ID = id,

                            Name = eventName,

                            Participants = new SortedSet<string>()
                        };
                    }

                    if (events[id].Name == eventName)
                    {
                        foreach (var participant in participants)
                        {
                            events[id].Participants.Add(participant);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            events = events
                .OrderByDescending(x => x.Value.Participants.Count)
                .ThenBy(x => x.Value.Name)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in events)
            {
                Console.WriteLine($"{kvp.Value.Name.Substring(1)} - {kvp.Value.Participants.Count}");

                foreach (var participant in kvp.Value.Participants)
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}