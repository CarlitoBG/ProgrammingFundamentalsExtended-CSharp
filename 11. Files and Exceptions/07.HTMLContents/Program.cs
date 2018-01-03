using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _07.HTMLContents
{
    class Program
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("input.txt");

            var title = string.Empty;
            var bodyParts = new List<string>();

            foreach (var line in lines)
            {
                if (line == "exit")
                {
                    break;
                }

                var elements = line.Split(' ');
                var tag = elements[0];
                var tagContent = elements[1];

                if (tag == "title")
                {
                    title = tagContent;
                }
                else
                {
                    bodyParts.Add($"\t<{tag}>{tagContent}</{tag}>");
                }
            }

            var result = new StringBuilder();

            result.AppendLine("<!DOCTYPE html>");
            result.AppendLine("<html>");
            result.AppendLine("<head>");

            if (title != string.Empty)
            {
                result.AppendLine($"\t<title>{title}</title>");
            }

            result.AppendLine("</head>");
            result.AppendLine("<body>");

            if (bodyParts.Any())
            {
                result.AppendLine(string.Join(Environment.NewLine, bodyParts));
            }

            result.AppendLine("</body>");
            result.AppendLine("</html>");

            File.WriteAllText("index.html", result.ToString().Trim());
        }
    }
}
