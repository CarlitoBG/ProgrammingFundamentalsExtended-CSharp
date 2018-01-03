using System;

namespace _07.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                var greater = GetMax(first, second);

                Console.WriteLine(greater);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());

                var greater = GetMax(first, second);

                Console.WriteLine(greater);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                var greater = GetMax(first, second);

                Console.WriteLine(greater);
            }
        }

        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            
            return second;
            
        }

        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }

            return second;
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            
            return second;          
        }
    }
}
