using System;

namespace ArraySymmetry
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            bool isSymetric = true;

            for (int i = 0; i < words.Length / 2; i++)
            {
                string firstWord = words[i];
                string lastWord = words[words.Length - 1 - i];

                if (firstWord != lastWord)
                {
                    isSymetric = false;
                    break;
                }
            }

            if (isSymetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
