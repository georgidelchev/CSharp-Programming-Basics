using System;

namespace EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            double pricePerOne = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (guestsCount >= 10 && guestsCount <= 15)
            {
                pricePerOne = pricePerOne - (pricePerOne * 0.15);
            }
            else if (guestsCount > 15 && guestsCount <= 20)
            {
                pricePerOne = pricePerOne - (pricePerOne * 0.20);
            }
            else if (guestsCount > 20)
            {
                pricePerOne = pricePerOne - (pricePerOne * 0.25);
            }

            double cakePrice = budget * 0.10;
            double totalSum = (guestsCount * pricePerOne) + cakePrice;

            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"It is party time! {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"No party! {moneyNeeded:f2} leva needed.");
            }
        }
    }
}
