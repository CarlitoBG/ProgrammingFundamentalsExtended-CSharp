using System;

namespace _17.CypherRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string cypherString = string.Empty;
            string lastString = string.Empty;

            bool addToEnd = true;

            for (int i = 0; i < number; i++)
            {
                string currentString = Console.ReadLine();

                if (currentString == "spin")
                {
                    addToEnd = !addToEnd;
                    i--;
                }

                if (addToEnd == true)
                {
                    cypherString = cypherString + currentString;
                }
                else if (addToEnd == false)
                {
                    cypherString = currentString + cypherString;
                }

                if (currentString == lastString)
                {
                    cypherString = string.Empty;

                    if (currentString == "spin")
                    {
                        addToEnd = !addToEnd;                                                               
                    }

                    lastString = currentString;                
                }

                lastString = currentString;
            }

            cypherString = cypherString.Replace("spin", string.Empty);
            Console.WriteLine(cypherString);        
        }
    }
}
