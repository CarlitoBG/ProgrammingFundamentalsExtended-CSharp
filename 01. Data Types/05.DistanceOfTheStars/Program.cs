using System;

namespace _05.DistanceOfTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal oneLightYear = 9450000000000;

            decimal distanceEarthToProxima = oneLightYear * 4.22M;
            decimal distanceEarthToMilkyWay = oneLightYear * 26000;
            decimal diameterOfMilkyWay = oneLightYear * 100000;
            decimal distnaceEarthToEdgeOfUniverse = oneLightYear * 46500000000;

            Console.WriteLine(distanceEarthToProxima.ToString("e2"));
            Console.WriteLine(distanceEarthToMilkyWay.ToString("e2"));
            Console.WriteLine(diameterOfMilkyWay.ToString("e2"));
            Console.WriteLine(distnaceEarthToEdgeOfUniverse.ToString("e2"));
        }
    }
}
