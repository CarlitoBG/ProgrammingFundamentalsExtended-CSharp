using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.InsertionSortUsingList
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var resultList = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool inserted = false;
                var currentElement = numbers[i];

                for (int listIndex = 0; listIndex < resultList.Count; listIndex++)
                {
                    var currentListElement = resultList[listIndex];

                    if (currentElement <= currentListElement)
                    {
                        inserted = true;
                        resultList.Insert(listIndex, currentElement);
                        break;
                    }
                }

                if (!inserted)
                {
                    resultList.Add(currentElement);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
