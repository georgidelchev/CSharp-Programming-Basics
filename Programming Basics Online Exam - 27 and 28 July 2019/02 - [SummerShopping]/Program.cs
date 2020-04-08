using System;

namespace SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double beachTowel = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            
            double umbrellaPrice = (beachTowel * 2) / 3;
            double sandalsPrice = umbrellaPrice * 0.75;
            double bagPrice = (sandalsPrice + beachTowel) / 3;
            double totalSum = umbrellaPrice + beachTowel + sandalsPrice + bagPrice;
            double discountedPrice = totalSum - (totalSum * (discount / 100.0));

            if (budget >= discountedPrice)
            {
                double moneyLeft = budget - discountedPrice;
                Console.WriteLine($"Annie's sum is {discountedPrice:f2} lv. She has {moneyLeft:f2} lv. left.");
            }
            else if (discountedPrice > budget)
            {
                double moneyNeeded = discountedPrice - budget;
                Console.WriteLine($"Annie's sum is {discountedPrice:f2} lv. She needs {moneyNeeded:f2} lv. more.");
            }

        }
    }
}
