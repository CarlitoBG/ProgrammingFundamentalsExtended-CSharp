using System;

namespace _16.TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            string result = string.Empty;
            
            for (int i = 0; i < number; i++)
            {
                string lines = Console.ReadLine();
                result += lines + delimiter;                
            }

            string removeLastDelimiter = result.Remove(result.Length - delimiter.Length, delimiter.Length); 
            Console.WriteLine(removeLastDelimiter);
        }
    }
}
