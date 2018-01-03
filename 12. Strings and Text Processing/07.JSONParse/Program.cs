using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.JSONParse
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

            var elements = inputLine
                .Split(" [{,]:\"".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var tempLine = string.Join(" ", elements);
            var tempLineParams = tempLine
                .Split("}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var param in tempLineParams)
            {
                var studentInfo = param.Trim().Split(' ');
                var name = studentInfo[1];
                var age = studentInfo[3];
                var grades = studentInfo.Skip(5).Select(int.Parse).ToList();

                var student = new Student
                {
                    Name = name,
                    Age = int.Parse(age),
                    Grades = grades
                };

                students.Add(student);
            }

            foreach (var student in students)
            {
                if (student.Grades.Count != 0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
            }
        }
    }
}