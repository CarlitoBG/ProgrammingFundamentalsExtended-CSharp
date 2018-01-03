using System;
using System.Collections.Generic;

namespace _10.Animals
{
    class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            while (inputLine != "I'm your Huckleberry")
            {
                var elements = inputLine.Split(' ');

                if (elements[0] != "talk")
                {
                    var className = elements[0];
                    var name = elements[1];
                    var age = int.Parse(elements[2]);
                    var parameter = int.Parse(elements[3]);

                    if (className == "Dog")
                    {
                        var newDog = new Dog();

                        newDog.Name = name;
                        newDog.Age = age;
                        newDog.NumberOfLegs = parameter;

                        dogs.Add(newDog.Name, newDog);
                    }
                    else if (className == "Cat")
                    {
                        var newCat = new Cat();

                        newCat.Name = name;
                        newCat.Age = age;
                        newCat.IntelligenceQuotient = parameter;

                        cats.Add(newCat.Name, newCat);
                    }
                    else if (className == "Snake")
                    {
                        var newSnake = new Snake();

                        newSnake.Name = name;
                        newSnake.Age = age;
                        newSnake.CrueltyCoefficient = parameter;

                        snakes.Add(newSnake.Name, newSnake);
                    }
                }
                else
                {
                    var name = elements[1];

                    if (dogs.ContainsKey(name))
                    {
                        dogs[name].ProduceSound();
                    }
                    else if (cats.ContainsKey(name))
                    {
                        cats[name].ProduceSound();
                    }
                    else if (snakes.ContainsKey(name))
                    {
                        snakes[name].ProduceSound();
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var animal in dogs.Values)
            {
                Console.WriteLine($"Dog: {animal.Name}, Age: {animal.Age}, Number Of Legs: {animal.NumberOfLegs}");
            }
            foreach (var animal in cats.Values)
            {
                Console.WriteLine($"Cat: {animal.Name}, Age: {animal.Age}, IQ: {animal.IntelligenceQuotient}");
            }
            foreach (var animal in snakes.Values)
            {
                Console.WriteLine($"Snake: {animal.Name}, Age: {animal.Age}, Cruelty: {animal.CrueltyCoefficient}");
            }
        }
    }
}
