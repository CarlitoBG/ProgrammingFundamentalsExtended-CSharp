using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _10.Products
{
    class Product
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }

    class Program
    {
        private static string dataBase = "StockedProducts.txt";
        private static SortedDictionary<string, Dictionary<string, Product>> activeProducts =
            new SortedDictionary<string, Dictionary<string, Product>>();

        public static void Main()
        {
            if (!File.Exists(dataBase))
            {
                File.Create(dataBase).Close();
            }

            CheckForStockedProducts();

            var inputLine = Console.ReadLine();

            while (inputLine != "exit")
            {
                var elements = inputLine.Split(' ');

                if (elements.Length > 1)
                {
                    StoreProducts(elements);
                }
                else if (elements[0] == "stock")
                {
                    Stock();
                }
                else if (elements[0] == "analyze")
                {
                    Analyze();
                }
                else if (elements[0] == "sales")
                {
                    Sales();
                }

                inputLine = Console.ReadLine();
            }
        }

        private static void CheckForStockedProducts()
        {
            var dataBaseLines = File.ReadAllLines(dataBase);

            foreach (var line in dataBaseLines)
            {
                var elements = line.Split(' ');

                var name = elements[0];
                var type = elements[1];
                var price = decimal.Parse(elements[2]);
                var quantity = int.Parse(elements[3]);

                if (!activeProducts.ContainsKey(type))
                {
                    activeProducts[type] = new Dictionary<string, Product>();
                }

                if (!activeProducts[type].ContainsKey(name))
                {
                    activeProducts[type][name] = new Product
                    {
                        Name = name,
                        Type = type,
                        Price = price,
                        Quantity = quantity
                    };
                }
            }
        }

        private static void StoreProducts(string[] elements)
        {
            var name = elements[0];
            var type = elements[1];
            var price = decimal.Parse(elements[2]);
            var quantity = int.Parse(elements[3]);

            if (!activeProducts.ContainsKey(type))
            {
                activeProducts[type] = new Dictionary<string, Product>();

                if (!activeProducts[type].ContainsKey(name))
                {
                    activeProducts[type][name] = new Product
                    {
                        Name = name,
                        Type = type,
                        Price = price,
                        Quantity = quantity
                    };
                }
            }

            if (activeProducts[type].ContainsKey(name))
            {
                activeProducts[type][name].Price = price;
                activeProducts[type][name].Quantity = quantity;
            }
            else
            {
                activeProducts[type][name] = new Product
                {
                    Name = name,
                    Type = type,
                    Price = price,
                    Quantity = quantity
                };
            }
        }

        private static void Sales()
        {
            var typeAndIncome = new Dictionary<string, decimal>();

            var income = 0m;

            foreach (var type in activeProducts)
            {
                foreach (var product in type.Value)
                {
                    income += product.Value.Price * product.Value.Quantity;
                }

                typeAndIncome[type.Key] = income;
                income = 0;
            }

            foreach (var type in typeAndIncome.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{type.Key}: ${type.Value:f2}");
            }
        }

        private static void Analyze()
        {
            var stockedProducts = File.ReadAllLines(dataBase);

            if (stockedProducts.Any())
            {
                foreach (var product in stockedProducts)
                {
                    var elements = product.Split(' ');

                    var name = elements[0];
                    var type = elements[1];
                    var price = decimal.Parse(elements[2]);
                    var quantity = int.Parse(elements[3]);

                    Console.WriteLine($"{type}, Product: {name}");
                    Console.WriteLine($"Price: ${price}, Amount Left: {quantity}");
                }
            }
            else
            {
                Console.WriteLine("No products stocked");
            }
        }

        private static void Stock()
        {
            var stock = new StringBuilder();

            foreach (var type in activeProducts)
            {
                foreach (var product in type.Value)
                {
                    stock.AppendLine($"{product.Value.Name} {product.Value.Type} {product.Value.Price} {product.Value.Quantity}");
                }
            }

            File.WriteAllText(dataBase, stock.ToString());
        }
    }
}