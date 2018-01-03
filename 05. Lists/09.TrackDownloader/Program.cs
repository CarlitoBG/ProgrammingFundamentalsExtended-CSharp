using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackDownloader
{
    class Program
    {
        static void Main()
        {
            var blacklist = Console.ReadLine().Split(' ').ToList();

            var filename = Console.ReadLine();

            var downloadedTracks = new List<string>();

            while (filename != "end")
            {
                bool isInBlacklist = false;

                foreach (var word in blacklist)
                {
                    if (filename.Contains(word))
                    {
                        isInBlacklist = true;
                        break;
                    }
                }

                if (!isInBlacklist)
                {
                    downloadedTracks.Add(filename);
                }

                filename = Console.ReadLine();
            }

            downloadedTracks.Sort();

            Console.WriteLine(string.Join(Environment.NewLine, downloadedTracks));
        }
    }
}
