using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.JSONstringify
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<int> Grades { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var students = new List<Student>();

            while (inputLine != "stringify")
            {
                var elements = inputLine
                    .Split(", :->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var name = elements[0];
                var age = int.Parse(elements[1]);
                var grades = elements.Skip(2).Select(int.Parse).ToList();

                students.Add(new Student
                {
                    Name = name,
                    Age = age,
                    Grades = grades
                });

                inputLine = Console.ReadLine();
            }

            var sb = new StringBuilder();

            foreach (var student in students)
            {
                sb.Append($"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}},");
            }

            Console.WriteLine($"[{sb.ToString().TrimEnd(',')}]");
        }
    }
}