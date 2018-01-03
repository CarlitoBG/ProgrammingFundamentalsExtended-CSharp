using System;
namespace _12.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            int number = Convert.ToInt32(value, 16);

            Console.WriteLine(number);
        }
    }
}
