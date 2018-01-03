using System;

namespace _10.DataOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number1 = ulong.Parse(Console.ReadLine());
            ulong number2 = ulong.Parse(Console.ReadLine());

            ulong lowestNumber = Math.Min(number1, number2);
            ulong greaterNumber = Math.Max(number1, number2);

            string bigType = string.Empty;
            string smallType = string.Empty;
            ulong smallTypeMaxValue = ulong.MinValue;

            if (greaterNumber >= lowestNumber)
            {
                if (greaterNumber >= byte.MinValue && greaterNumber <= byte.MaxValue)
                {
                    bigType = "byte";
                }
                else if (greaterNumber >= ushort.MinValue && greaterNumber <= ushort.MaxValue)
                {
                    bigType = "ushort";
                }
                else if (greaterNumber >= uint.MinValue && greaterNumber <= uint.MaxValue)
                {
                    bigType = "uint";
                }
                else if (greaterNumber >= ulong.MinValue && greaterNumber <= ulong.MaxValue)
                {
                    bigType = "ulong";
                }

                if (lowestNumber >= byte.MinValue && lowestNumber <= byte.MaxValue)
                {
                    smallType = "byte";
                    smallTypeMaxValue = byte.MaxValue;
                }
                else if (lowestNumber >= ushort.MinValue && lowestNumber <= ushort.MaxValue)
                {
                    smallType = "ushort";
                    smallTypeMaxValue = ushort.MaxValue;
                }
                else if (lowestNumber >= uint.MinValue && lowestNumber <= uint.MaxValue)
                {
                    smallType = "uint";
                    smallTypeMaxValue = uint.MaxValue;
                }
                else if (lowestNumber >= ulong.MinValue && lowestNumber <= ulong.MaxValue)
                {
                    smallType = "ulong";
                    smallTypeMaxValue = ulong.MaxValue;
                }

                Console.WriteLine($"bigger type: {bigType}");
                Console.WriteLine($"smaller type: {smallType}");
                Console.WriteLine($"{greaterNumber} can overflow {smallType} {Math.Round((double)greaterNumber / smallTypeMaxValue)} times");
            }          
        }
    }
}
