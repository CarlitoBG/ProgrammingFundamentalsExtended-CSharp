using System;

namespace _02.CommandInterpreter
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var command = Console.ReadLine();

            while (command != "end")
            {
                var commandParams = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandParams[0] == "reverse" || commandParams[0] == "sort")
                {
                    var startIndex = int.Parse(commandParams[2]);
                    var count = int.Parse(commandParams[4]);

                    if (ValidParams(array, commandParams, startIndex, count))
                    {
                        switch (commandParams[0])
                        {
                            case "reverse":
                                Reverse(array, startIndex, count);
                                break;
                            case "sort":
                                Sort(array, startIndex, count);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (commandParams[0] == "rollLeft" || commandParams[0] == "rollRight")
                {
                    var count = int.Parse(commandParams[1]);

                    if (count >= 0)
                    {
                        switch (commandParams[0])
                        {
                            case "rollLeft":
                                RollLeft(array, count);
                                break;
                            case "rollRight":
                                RollRight(array, count);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static bool ValidParams(string[] array, string[] commandParams, int startIndex, int count)
        {
            return startIndex >= 0 && startIndex < array.Length && count >= 0 && (count + startIndex) <= array.Length;
        }

        private static void Reverse(string[] array, int startIndex, int count)
        {
            for (int i = 0; i < count / 2; i++)
            {
                var temp = array[startIndex + i];
                array[startIndex + i] = array[startIndex + count - 1 - i];
                array[startIndex + count - 1 - i] = temp;
            }
        }

        private static void Sort(string[] array, int startIndex, int count)
        {
            var tempArray = new string[count];

            for (int i = 0; i < count; i++)
            {
                tempArray[i] = array[startIndex + i];
            }

            for (int i = 0; i < tempArray.Length - 1; i++)
            {
                var firstUnsorted = i + 1;

                while (firstUnsorted > 0)
                {
                    if (tempArray[firstUnsorted].CompareTo(tempArray[firstUnsorted - 1]) < 0)
                    {
                        var temp = tempArray[firstUnsorted];
                        tempArray[firstUnsorted] = tempArray[firstUnsorted - 1];
                        tempArray[firstUnsorted - 1] = temp;
                    }

                    firstUnsorted--;
                }
            }

            for (int i = 0; i < count; i++)
            {
                array[startIndex + i] = tempArray[i];
            }
        }

        private static void RollLeft(string[] array, int count)
        {
            for (int i = 0; i < count % array.Length; i++)
            {
                var temp = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = temp;
            }
        }

        private static void RollRight(string[] array, int count)
        {
            for (int i = 0; i < count % array.Length; i++)
            {
                var temp = array[array.Length - 1];

                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }

                array[0] = temp;
            }
        }
    }      
}