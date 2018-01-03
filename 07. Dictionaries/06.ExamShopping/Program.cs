using System;
using System.Collections.Generic;

namespace _06.ExamShopping
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var productsQuantity = new Dictionary<string, int>();

            while (inputLine != "shopping time")
            {
                var command = inputLine.Split();
                var product = command[1];
                var quantity = int.Parse(command[2]);

                if (!productsQuantity.ContainsKey(product))
                {
                    productsQuantity[product] = 0;
                }

                productsQuantity[product] += quantity;

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (inputLine != "exam time")
            {
                var command = inputLine.Split();
                var product = command[1];
                var quantity = int.Parse(command[2]);

                if (!productsQuantity.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (productsQuantity[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        productsQuantity[product] -= quantity;

                        if (productsQuantity[product] < 0)
                        {
                            productsQuantity[product] = 0;
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var productQuantityPair in productsQuantity)
            {
                var product = productQuantityPair.Key;
                var quantity = productQuantityPair.Value;

                if (quantity > 0)
                {
                    Console.WriteLine($"{product} -> {quantity}");
                }
            }
        }
    }
}
