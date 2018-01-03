using System;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');

            string inputName = Console.ReadLine();

            while (inputName != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == inputName)
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                }

                inputName = Console.ReadLine();
            }
        }
    }
}
