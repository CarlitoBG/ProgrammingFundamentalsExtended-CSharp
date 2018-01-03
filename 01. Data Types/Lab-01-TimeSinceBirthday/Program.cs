using System;

namespace TimeSinceBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Years - ");

            byte years = byte.Parse(Console.ReadLine());
            int days = years * 365;
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes.",
                years, days, hours, minutes);
        }
    }
}
