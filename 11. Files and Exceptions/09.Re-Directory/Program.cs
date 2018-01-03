using System.Collections.Generic;
using System.IO;

namespace _09.Re_Directory
{
    class Program
    {
        public static void Main()
        {
            var files = Directory.GetFiles("input");

            var outputFiles = new List<FileInfo>();

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                outputFiles.Add(fileInfo);
            }

            Directory.CreateDirectory("output");

            foreach (var file in outputFiles)
            {
                if (!Directory.Exists($"output\\{file.Extension.Trim('.')}s"))
                {
                    Directory.CreateDirectory($"output\\{file.Extension.Trim('.')}s");
                }

                File.Move($"input\\{file.Name}", $"output\\{file.Extension.Trim('.')}s\\{file.Name}");
            }
        }
    }
}
