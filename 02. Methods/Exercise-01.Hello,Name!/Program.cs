using System;

namespace Hello_Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Greeting(name);
        }

        static void Greeting(string name)
        {            
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
