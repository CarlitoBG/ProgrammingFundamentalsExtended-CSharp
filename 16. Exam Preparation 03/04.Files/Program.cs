using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files
{
    public class File
    {
        public string Root { get; set; }

        public string Name { get; set; }

        public long Size { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var files = new List<File>();

            for (int i = 0; i < n; i++)
            {
                var inputFile = Console.ReadLine()
                    .Split("\\;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var root = inputFile[0];
                var name = inputFile[inputFile.Length - 2];
                var size = long.Parse(inputFile[inputFile.Length - 1]);

                var currentFile = new File
                {
                    Root = root,

                    Name = name, 

                    Size = size
                };

                if (files.Any(x => x.Root == root && x.Name == name))
                {
                    foreach (var file in files)
                    {
                        if (file.Root == root && file.Name == name)
                        {
                            file.Size = size;
                        }
                    }
                }
                else
                {
                    files.Add(currentFile);
                }
            }

            var query = Console.ReadLine().Split();

            var extension = query[0];
            var queryRoot = query[2];

            files = files
                .Where(x => x.Root == queryRoot)
                .Where(x => x.Name.EndsWith($".{extension}"))
                .OrderByDescending(x => x.Size)
                .ThenBy(x => x.Name)
                .ToList();

            if (files.Any())
            {
                foreach (var file in files)
                {
                    Console.WriteLine($"{file.Name} - {file.Size} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}