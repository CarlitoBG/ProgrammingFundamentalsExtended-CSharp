using System;
using System.Globalization;

namespace _01.SoftUniCoffeeOrders
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var totalMoney = 0m;

            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime
                    .ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = long.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                var coffeePrice = ((daysInMonth * capsulesCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
                totalMoney += coffeePrice;
            }

            Console.WriteLine($"Total: ${totalMoney:f2}");
        }
    }
}