using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocardsCount = int.Parse(Console.ReadLine());
            int processorsCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double videocardsPrice = 250.00;
            double processorsPrice = (videocardsCount * 250) * 0.35;
            double ramPrice = (videocardsCount * 250) * 0.10;

            double totalPrice = (videocardsCount * videocardsPrice) + (processorsCount * processorsPrice) + (ramCount * ramPrice);

            if (videocardsCount > processorsCount)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else if (totalPrice > budget)
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
            }
        }
    }
}
