using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Exercises
{
    class Exercise
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var exercises = new List<Exercise>();

            while (inputLine != "go go go")
            {
                var elements = inputLine.Split("-> ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var topic = elements[0];
                var courseName = elements[1];
                var judgeContestLink = elements[2];
                var problems = elements.Skip(3).ToList();

                var newExercise = new Exercise();

                newExercise.Topic = topic;
                newExercise.CourseName = courseName;
                newExercise.JudgeContestLink = judgeContestLink;
                newExercise.Problems = problems;

                exercises.Add(newExercise);

                inputLine = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                var count = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }
        }
    }
}
