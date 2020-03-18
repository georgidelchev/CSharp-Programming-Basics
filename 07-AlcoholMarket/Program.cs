using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQty = double.Parse(Console.ReadLine());
            double wineQty = double.Parse(Console.ReadLine());
            double rakiaQty = double.Parse(Console.ReadLine());
            double whiskeyQty = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - (rakiaPrice * 0.40); // 40% from rakiaPrice
            double beerPrice = rakiaPrice - (rakiaPrice * 0.80); // 80% from rakiaPrice

            double rakiaCosts = rakiaQty * rakiaPrice;
            double wineCosts = wineQty * winePrice;
            double beerCosts = beerQty * beerPrice;
            double whiskeyCosts = whiskeyQty * whiskeyPrice;

            double totalPrice = rakiaCosts + wineCosts + beerCosts + whiskeyCosts;

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
