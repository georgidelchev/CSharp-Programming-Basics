using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            
            double giftPrice = double.Parse(Console.ReadLine());

            double magnoliasPrice = 3.25;
            double hyacinthsPrice = 4.00;
            double rosesPrice = 3.50;
            double cactusesPrice = 8.00;

            double totalSum = (magnoliasCount * magnoliasPrice) + (hyacinthsCount* hyacinthsPrice) + (rosesCount* rosesPrice) + (cactusesCount*cactusesPrice);
            double taxes = totalSum * 0.05;
            double sumAfterTaxes = totalSum - taxes;

            if (sumAfterTaxes >= giftPrice)
            {
                double leftMoney = sumAfterTaxes - giftPrice;
                Console.WriteLine($"She is left with {Math.Floor(leftMoney)} leva.");
            }
            else if (giftPrice > sumAfterTaxes)
            {
                double moneyNeeded = giftPrice - sumAfterTaxes;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyNeeded)} leva.");
            }
        }
    }
}
