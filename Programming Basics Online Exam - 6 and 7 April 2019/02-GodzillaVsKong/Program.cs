using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double clothesPrice = peopleCount * clothes;
            if (peopleCount > 150)
            {
                clothesPrice = clothesPrice - (clothesPrice * 0.10);
            }
            double totalSum = decor + clothesPrice;
            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else if (totalSum >= budget)
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
        }
    }
}
