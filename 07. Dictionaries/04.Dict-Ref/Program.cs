using System;
using System.Collections.Generic;

namespace _04.Dict_Ref
{
    class Program
    {
        static void Main()
        {
            var inputLines = Console.ReadLine();

            var resultDict = new Dictionary<string, int>();

            while (inputLines != "end")
            {
                var elements = inputLines.Split();
                var firstElement = elements[0];
                var lastElement = elements[elements.Length - 1];

                var number = 0;

                if (int.TryParse(lastElement, out number))
                {
                    resultDict[firstElement] = number;
                }
                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        var referencedValue = resultDict[lastElement];
                        resultDict[firstElement] = referencedValue;
                    }
                }

                inputLines = Console.ReadLine();
            }

            foreach (var itemPricePair in resultDict)
            {
                Console.WriteLine($"{itemPricePair.Key} === {itemPricePair.Value}");
            }
        }
    }
}
