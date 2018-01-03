using System;

namespace Phone
{
    class Program
    {
        static void Main()
        {
            string[] phones = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "done")
            {
                if (input[0] == "call")
                {
                    CallMethod(phones, names, input);
                }
                else if (input[0] == "message")
                {
                    MessageMethod(phones, names, input);
                }

                input = Console.ReadLine().Split(' ');
            }
        }

        private static void CallMethod(string[] phones, string[] names, string[] input)
        {
            var sumOfDigits = 0;

            for (int i = 0; i < names.Length; i++)
            {
                var digits = phones[i].ToCharArray();

                if (input[1] == phones[i])
                {
                    Console.WriteLine($"calling {names[i]}...");

                    foreach (var digit in digits)
                    {
                        if (digit >= '0' && digit <= '9') 
                        {
                            sumOfDigits += digit - '0';
                        }
                    }
                }
                else if (input[1] == names[i])
                {
                    Console.WriteLine($"calling {phones[i]}...");

                    foreach (var digit in digits)
                    {
                        if (digit >= '0' && digit <= '9')
                        {
                            sumOfDigits += digit - '0';
                        }
                    }
                }
            }

            if (sumOfDigits % 2 == 0)
            {
                string answer = string.Format("call ended. duration: {0:00}:{1:00}",
                    sumOfDigits / 60, sumOfDigits % 60);

                Console.WriteLine(answer);
            }
            else if (sumOfDigits % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
        }

        private static void MessageMethod(string[] phones, string[] names, string[] input)
        {
            var sumOfDigits = 0;

            for (int i = 0; i < names.Length; i++)
            {
                var digits = phones[i].ToCharArray();

                if (input[1] == phones[i])
                {
                    Console.WriteLine($"sending sms to {names[i]}...");

                    foreach (var digit in digits)
                    {
                        if (digit >= '0' && digit <= '9')
                        {
                            sumOfDigits -= digit - '0';
                        }
                    }
                }
                else if (input[1] == names[i])
                {
                    Console.WriteLine($"sending sms to {phones[i]}...");

                    foreach (var digit in digits)
                    {
                        if (digit >= '0' && digit <= '9')
                        {
                            sumOfDigits -= digit - '0';
                        }
                    }
                }
            }

            if (sumOfDigits % 2 == 0)
            {
                Console.WriteLine("meet me there");
            }
            else if (sumOfDigits % 2 != 0)
            {
                Console.WriteLine("busy");
            }
        }
    }
}
