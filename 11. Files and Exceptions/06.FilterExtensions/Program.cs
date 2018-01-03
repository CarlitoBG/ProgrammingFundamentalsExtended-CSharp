using System;
using System.Collections.Generic;
using System.IO;

namespace _06.FilterExtensions
{
    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var files = Directory.GetFiles("input");

            var outputFiles = new List<FileInfo>();

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                if (fileInfo.Extension == "." + inputLine)
                {
                    outputFiles.Add(fileInfo);
                }
            }

            foreach (var file in outputFiles)
            {
                Console.WriteLine(file.Name);
            }   
        }
    }
}
