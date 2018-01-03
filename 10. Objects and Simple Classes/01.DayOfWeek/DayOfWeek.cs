using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            var dateAsString = Console.ReadLine();

            var date = DateTime.ParseExact(dateAsString, "d-M-yyyy", 
                CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
