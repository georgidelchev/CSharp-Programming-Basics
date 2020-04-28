using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonNeeded = int.Parse(Console.ReadLine());
            int paintNeeded = int.Parse(Console.ReadLine());
            int diluentNeeded = int.Parse(Console.ReadLine());
            int hoursNeeded = int.Parse(Console.ReadLine());

            double nylonPrice = 1.50; // per m2
            double paintPrice = 14.50; // per liter
            double diluentPrice = 5.00; // per liter

            double totalNylonPrice = (nylonNeeded + 2) * nylonPrice;
            double totalPaintPrice = (paintNeeded + (paintNeeded * 0.10)) * paintPrice;
            double totalDiluentPrice = diluentNeeded * diluentPrice;
            double totalSum = (totalNylonPrice + totalPaintPrice + totalDiluentPrice) + 0.40;

            double moneyForWorkers = ((totalSum * 0.30) * hoursNeeded) + totalNylonPrice + totalPaintPrice + totalDiluentPrice + 0.40;
            Console.WriteLine($"Total expenses: {moneyForWorkers:f2} lv.");
        }
    }
}
