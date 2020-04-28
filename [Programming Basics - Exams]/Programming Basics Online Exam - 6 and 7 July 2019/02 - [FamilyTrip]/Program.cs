using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            int percentForExtraCosts = int.Parse(Console.ReadLine());

            if (nightsCount > 7)
            {
                nightPrice = nightPrice - (nightPrice * 0.05);
            }
            double nightsPrice = nightsCount * nightPrice;
            double extraCosts = budget * (percentForExtraCosts * 1.00 / 100);
            double totalSum = nightsPrice + extraCosts;

            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:f2} leva after vacation.");
            }
            else if (totalSum > budget)
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"{moneyNeeded:f2} leva needed.");
            }
        }
    }
}
