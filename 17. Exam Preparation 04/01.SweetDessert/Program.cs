using System;

namespace _01.SweetDessert
{
    public class Program
    {
        public static void Main()
        {
            var cash = decimal.Parse(Console.ReadLine());
            var numberOfGuests = int.Parse(Console.ReadLine());
            var priceOfBananas = decimal.Parse(Console.ReadLine());
            var priceOfEggs = decimal.Parse(Console.ReadLine());
            var priceOfBerries = decimal.Parse(Console.ReadLine());

            var set = Math.Ceiling(numberOfGuests / 6m);
            var bananasPerSet = 2;
            var eggsPerSet = 4;
            var berriesPerSet = 0.2m;

            var moneyNeeded = set * (bananasPerSet * priceOfBananas)
                + set * (eggsPerSet * priceOfEggs) + set * (berriesPerSet * priceOfBerries);

            if (moneyNeeded <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                var moreMoneyNeeded = Math.Abs(moneyNeeded - cash);

                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moreMoneyNeeded:f2}lv more.");
            }
        }
    }
}