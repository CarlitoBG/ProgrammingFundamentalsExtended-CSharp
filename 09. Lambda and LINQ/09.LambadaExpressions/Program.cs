using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.LambadaExpressions
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var lambadaExpresssions = new Dictionary<string, Dictionary<string, string>>();

            while (inputLine != "lambada")
            {
                if (inputLine != "dance")
                {
                    var elements = inputLine.Split("=>. ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var selector = elements[0];
                    var selectorObject = elements[1];
                    var property = elements[2];

                    if (!lambadaExpresssions.ContainsKey(selector))
                    {
                        lambadaExpresssions[selector] = new Dictionary<string, string>();
                    }
                    lambadaExpresssions[selector][selectorObject] = property;
                }
                else
                {
                    lambadaExpresssions = lambadaExpresssions
                        .ToDictionary(selector => selector.Key, 
                        selector => selector.Value.ToDictionary(selectorObject => selectorObject.Key, 
                        selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }
                
                inputLine = Console.ReadLine();
            }

            foreach (var selector in lambadaExpresssions)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine($"{selector.Key} => {selectorObject.Key}.{selectorObject.Value}");
                }
            }
        }
    }
}
