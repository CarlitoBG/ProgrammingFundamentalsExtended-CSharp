using System;

    class PriceChangeAlert
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < number - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());

                double difference = Process(lastPrice, currentPrice);

                bool isSignificantDifference = IsDifferent(difference, threshold);

                string message = GetMessage(currentPrice, lastPrice, difference, isSignificantDifference);

                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string GetMessage(double currentPrice, double lastPrice, double difference, bool isTrueOrFalse)
        {
            string message = string.Empty;

            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isTrueOrFalse)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (isTrueOrFalse && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (isTrueOrFalse && (difference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }

            return message;
        }

        private static bool IsDifferent(double threshold, double difference)
        {
            if (Math.Abs(threshold) >= difference)
            {
               return true;
            }

            return false;
        }

        private static double Process(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;

            return result;
        }
    }
