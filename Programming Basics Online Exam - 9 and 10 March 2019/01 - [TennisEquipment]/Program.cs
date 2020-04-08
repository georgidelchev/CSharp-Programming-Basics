using System;

namespace TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennisRocketPrice = double.Parse(Console.ReadLine());
            int tennisRocketsCount = int.Parse(Console.ReadLine());
            int shoesCount = int.Parse(Console.ReadLine());

            double shoesPrice = tennisRocketPrice / 6;

            double rocketsPrice = tennisRocketsCount * tennisRocketPrice;
            double totalShoesPrice = shoesPrice * shoesCount;
            double otherEquipment = (rocketsPrice + totalShoesPrice) * 0.20;
            double totalSum = rocketsPrice + totalShoesPrice + otherEquipment;
            double djokovicPrice = totalSum / 8;
            double sponsorsPrice = totalSum * 7 / 8;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(djokovicPrice)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsorsPrice)}");
        }
    }
}
