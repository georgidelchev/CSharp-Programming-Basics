using System;

namespace GodzillaVsKongMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int workerCount = int.Parse(Console.ReadLine());
            double clothesForOneWorkerPrice = double.Parse(Console.ReadLine());

            double decor = movieBudget * 0.10;
            double clothesTotalPrice = clothesForOneWorkerPrice * workerCount;


            if (workerCount >= 150)
            {
                double discount = clothesTotalPrice * 0.10;
                clothesTotalPrice -= discount;
            }
            double totalPriceForTheMovie = decor + clothesTotalPrice;

            if (movieBudget >= totalPriceForTheMovie)
            {
                double moneyLeft = movieBudget - totalPriceForTheMovie;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else if (totalPriceForTheMovie > movieBudget)
            {
                double moneyNeeded = totalPriceForTheMovie - movieBudget;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
        }
    }
}
