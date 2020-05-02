using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasQty = double.Parse(Console.ReadLine());
            double orangesQty = double.Parse(Console.ReadLine());
            double raspberriesQty = double.Parse(Console.ReadLine());
            double strawberriesQty = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberryPrice / 2;
            double orangesPrice = raspberriesPrice - (raspberriesPrice * 0.40);
            double bananasPrice = raspberriesPrice - (raspberriesPrice * 0.80);

            double totalSum = strawberryPrice * strawberriesQty + bananasPrice * bananasQty + orangesPrice * orangesQty + raspberriesPrice * raspberriesQty;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
