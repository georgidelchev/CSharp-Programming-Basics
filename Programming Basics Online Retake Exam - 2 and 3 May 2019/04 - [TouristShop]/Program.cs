using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int productsCount = 0;

            string productName = Console.ReadLine();
            double productsPrice = 0;
            double totalProductsPrice = 0;

            while (productName != "Stop")
            {
                productsPrice = double.Parse(Console.ReadLine());
                productsCount++;
                if (productsCount % 3 == 0)
                {
                    productsPrice /= 2;
                }
                if (productsPrice > budget)
                {
                    break;
                }
                totalProductsPrice += productsPrice;
                budget -= productsPrice;

                productName = Console.ReadLine();
            }
            if (budget >= productsPrice)
            {
                Console.WriteLine($"You bought {productsCount} products for {totalProductsPrice:f2} leva.");
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {Math.Abs(budget - productsPrice):f2} leva!");
            }
        }
    }
}
