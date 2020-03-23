using System;
namespace ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineYardInQuadMeters = int.Parse(Console.ReadLine());
            double grapesForOneQuadMeter = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double totalGrape = vineYardInQuadMeters * grapesForOneQuadMeter;
            double wine = 0.40 * totalGrape / 2.5;

            if (wine >= wineNeeded)
            {
                double wineLeft = wine - wineNeeded;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineLeft / workersCount)} liters per person.");
            }
            else if (wine < wineNeeded)
            {
                double wineThatNeeded = wineNeeded - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineThatNeeded)} liters wine needed.");
            }
        }
    }
}