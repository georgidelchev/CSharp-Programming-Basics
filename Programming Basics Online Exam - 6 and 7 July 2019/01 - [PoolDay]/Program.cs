using System;

namespace PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            double entryPrice = double.Parse(Console.ReadLine());
            double deckchairPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double totalEntryPrice = peopleCount * entryPrice;
            double totalDeckchairsNeeded = Math.Ceiling(peopleCount * 0.75);
            double totalUmbrellasNeeded = Math.Ceiling(peopleCount * 0.50);

            double deckchairsTotalPrice = totalDeckchairsNeeded * deckchairPrice;
            double umbrellasTotalPrice = totalUmbrellasNeeded * umbrellaPrice;

            double totalSum = totalEntryPrice + deckchairsTotalPrice + umbrellasTotalPrice;

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
