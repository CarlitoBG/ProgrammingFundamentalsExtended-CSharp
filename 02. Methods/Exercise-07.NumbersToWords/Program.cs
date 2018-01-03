using System;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int lines = 0; lines < n; lines++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > 999)
                {
                    result = "too large";
                }
                else if (number < -999)
                {
                    result = "too small";
                }
                else if (number >= -999 && number <= 999)
                {
                    if (number < 100 && number > -100)
                    {
                        continue;
                    }

                    if (number < 0)
                    {
                        Console.Write("minus ");
                        result = Letterize(Math.Abs(number));
                    }
                    else
                    {
                        result = Letterize(number);
                    }               
                }

                Console.WriteLine(result);
            }         
        }

        static string Letterize(int number)
        {
            string result = string.Empty;

            if (((number / 10) % 10) == 1)
            {
                string hundreds = Hundreds(number);
                string tenths = Tenths(number);

                result = $"{hundreds}{tenths}";
            }
            else
            {
                if (((number / 10) % 10) == 0 && ((number % 10) == 0))
                {
                    string hundreds = Hundreds(number);

                    result = hundreds;
                }
                else
                {
                    string hundreds = Hundreds(number);
                    string tenths = Tenths(number);
                    string units = Units(number);

                    result = $"{hundreds}{tenths}{units}";
                }
            }
            
            return result;
        }

        static string Hundreds(int number)
        {
            string hundreds = string.Empty;

            number /= 100;

            switch (number)
            {
                case 1: Console.Write("one-hundred"); break;
                case 2: Console.Write("two-hundred"); break;
                case 3: Console.Write("three-hundred"); break;
                case 4: Console.Write("four-hundred"); break;
                case 5: Console.Write("five-hundred"); break;
                case 6: Console.Write("six-hundred"); break;
                case 7: Console.Write("seven-hundred"); break;
                case 8: Console.Write("eight-hundred"); break;
                case 9: Console.Write("nine-hundred"); break;
            }

            return hundreds;
        }

        static string Tenths(int number)
        {
            string tenths = string.Empty;

            if ((number / 10) % 10 == 1)
            {
                number = number % 10;

                switch (number)
                {
                    case 0: Console.Write(" and ten"); break;
                    case 1: Console.Write(" and eleven"); break;
                    case 2: Console.Write(" and twelve"); break;
                    case 3: Console.Write(" and thirteen"); break;
                    case 4: Console.Write(" and fourteen"); break;
                    case 5: Console.Write(" and fifteen"); break;
                    case 6: Console.Write(" and sixteen"); break;
                    case 7: Console.Write(" and seventeen"); break;
                    case 8: Console.Write(" and eighteen"); break;
                    case 9: Console.Write(" and nineteen"); break;
                }
            }
            else if ((number / 10) % 10 != 1)
            {
                number = (number / 10) % 10;

                switch (number)
                {
                    case 0: Console.Write(" and "); break;
                    case 2: Console.Write(" and twenty "); break;
                    case 3: Console.Write(" and thirty "); break;
                    case 4: Console.Write(" and fourty "); break;
                    case 5: Console.Write(" and fifty "); break;
                    case 6: Console.Write(" and sixty "); break;
                    case 7: Console.Write(" and seventy "); break;
                    case 8: Console.Write(" and eighty "); break;
                    case 9: Console.Write(" and ninety "); break;
                }
            }

            return tenths;
        }

        static string Units(int number)
        {
            string units = string.Empty;

            number = number % 10;

            switch (number)
            {
                case 1: Console.Write("one"); break;
                case 2: Console.Write("two"); break;
                case 3: Console.Write("three"); break;
                case 4: Console.Write("four"); break;
                case 5: Console.Write("five"); break;
                case 6: Console.Write("six"); break;
                case 7: Console.Write("seven"); break;
                case 8: Console.Write("eight"); break;
                case 9: Console.Write("nine"); break;
            }

            return units;
        }
    }
}
