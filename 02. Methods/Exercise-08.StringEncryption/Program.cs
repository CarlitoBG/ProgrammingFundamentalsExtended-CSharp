using System;

namespace StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int lines = 0; lines < number; lines++)
            {
                char character = char.Parse(Console.ReadLine());

                var encryptedString = Encrypt(character);

                result += encryptedString;
            }

            Console.WriteLine(result);
        }

        static string Encrypt(char letter)
        {
            var asciiCode = (int)letter;

            int firstDigit = GetFirstDigit(asciiCode);
            int lastDigit = GetLastDigit(asciiCode);

            char firstSymbol = (char)(asciiCode + lastDigit);
            char lastSymbol = (char)(asciiCode - firstDigit);

            string result = $"{firstSymbol}{firstDigit}{lastDigit}{lastSymbol}";

            return result;
        }

        static int GetFirstDigit(int asciiCode)
        {
            int firstDigit = asciiCode;

            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }

            return firstDigit;
        }

        static int GetLastDigit(int asciiCode)
        {
            return asciiCode % 10;
        }
    }
}
