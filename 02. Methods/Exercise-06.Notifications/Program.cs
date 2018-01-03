using System;

namespace Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();

                if (result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();

                    string success = ShowSuccess(operation, message);

                    Console.WriteLine(success);
                }
                else if (result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());

                    string error = ShowError(operation, code);

                    Console.WriteLine(error);
                }
                else
                {
                    continue;
                }
            }
        }

        static string ShowSuccess(string operation, string message)
        {
            return $"Successfully executed {operation}.\n==============================\nMessage: {message}.";
        }

        static string ShowError(string operation, int code)
        {
            var reason = string.Empty;

            if (code > 0)
            {
                reason = "Invalid Client Data";
            }
            else if (code < 0)
            {
                reason = "Internal System Failure";
            }

            return $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: {reason}.";
        }
    }
}
