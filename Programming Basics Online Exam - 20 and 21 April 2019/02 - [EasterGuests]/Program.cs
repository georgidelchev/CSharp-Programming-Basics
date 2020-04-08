using System;

namespace EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double neededEasterBreads = Math.Ceiling(guestsCount * 1.00 / 3);
            double neededEggs = guestsCount * 2;

            double easterBreadsPrice = neededEasterBreads * 4;
            double eggsPrice = neededEggs * 0.45;

            double totalSum = easterBreadsPrice + eggsPrice;

            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Lyubo bought {neededEasterBreads} Easter bread and {neededEggs} eggs.");
                Console.WriteLine($"He has {moneyLeft:f2} lv. left.");
            }
            else
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {moneyNeeded:f2} lv. more.");
            }
        }
    }
}
