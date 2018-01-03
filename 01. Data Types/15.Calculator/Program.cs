using System;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = int.Parse(Console.ReadLine());
            string operat = Console.ReadLine();
            int operand2 = int.Parse(Console.ReadLine());

            switch (operat)
            {
                case "+":
                    Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                    break;
                case "-":
                    Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                    break;
                case "/":
                    Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");
                    break;
                default:
                    break;
            }
        }
    }
}
