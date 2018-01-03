using System;

namespace ResizableArray
{
    class Program
    {
        static void Main()
        {
            string[] commands = Console.ReadLine().Split(' ');

            int?[] array = new int?[4];

            string result = string.Empty;

            while (commands[0] != "end")
            {
                bool arrayIsFull = true;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == null)
                    {
                        arrayIsFull = false;
                        break;
                    }
                }

                if (commands[0] == "push")
                {
                    if (arrayIsFull)
                    {
                        int?[] newArray = new int?[array.Length];

                        for (int i = 0; i < array.Length; i++)
                        {
                            newArray[i] = array[i];
                        }

                        array = new int?[array.Length * 2];

                        for (int i = 0; i < newArray.Length; i++)
                        {
                            array[i] = newArray[i];
                        }
                    }

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == null)
                        {
                            array[i] = int.Parse(commands[1]);
                            break;
                        }
                    }
                }
                else if (commands[0] == "pop")
                {
                    for (int i = array.Length - 1; i >= 0; i--)
                    {
                        if (array[i] != null)
                        {
                            array[i] = null;
                            break;
                        }
                    }
                }
                else if (commands[0] == "removeAt")
                {
                    for (int i = int.Parse(commands[1]); i < array.Length; i++)
                    {
                        if (i < array.Length - 1)
                        {
                            array[i] = array[i + 1];
                        }
                    }

                    array[array.Length - 1] = null;
                }
                else if (commands[0] == "clear")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = null;
                    }
                }

                commands = Console.ReadLine().Split(' ');
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    result += array[i] + " ";
                }
            }

            if (result != string.Empty)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("empty array");
            }
        }
    }
}
