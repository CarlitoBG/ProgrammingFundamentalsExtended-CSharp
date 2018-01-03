using System;

namespace _09.CapitalizeWords
{
    class Program
    {
        public static void Main()
        {
            var sentence = Console.ReadLine();

            while (sentence != "end")
            {
                var words = sentence
                    .ToLower()
                    .Split(" .,:;-=+<>~`|{}[]\\?!/()#$%^&*\"".ToCharArray(), 
                    StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1);
                }

                Console.WriteLine(string.Join(", ", words));

                sentence = Console.ReadLine();
            }
        }
    }
}