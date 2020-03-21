using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int talkingDollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            // toys prices
            double puzzlePrice = 2.60;
            double talkingDollPrice = 3.00;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.00;

            int totalPurchasedToys = puzzlesCount + talkingDollsCount + bearsCount + minionsCount + trucksCount;
            double discountPrice = 0;
            double totalSum = puzzlesCount * puzzlePrice + talkingDollsCount * talkingDollPrice + bearsCount * bearPrice + minionsCount * minionPrice + trucksCount * truckPrice;

            if (totalPurchasedToys >= 50)
            {
                discountPrice = totalSum * 0.25; //25% from totalSum
                totalSum = totalSum - discountPrice;
            }

            double moneyLeftAfterRent = totalSum - (totalSum * 0.10);

            if (moneyLeftAfterRent > tripPrice)
            {
                double leftMoney = moneyLeftAfterRent - tripPrice;
                Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
            }
            else if (moneyLeftAfterRent < tripPrice)
            {
                double neededMoney = tripPrice - moneyLeftAfterRent;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }
        }
    }
}
