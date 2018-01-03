using System;

namespace _06.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);

            Console.WriteLine(result);
        }

        static double RaiseToPower(double number, int power)
        {
            double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result = result * number;
            }

            return result;
        }
    }
}
