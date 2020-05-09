using System;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());

            double flourPackage = 750;
            double sugatPackage = 950;

            double maxFlour = double.MinValue;
            double maxSugar = double.MinValue;

            double totalNeededFlour = 0;
            double totalNeededSugar = 0;

            for (int i = 1; i <= easterBreads; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());

                if (flour > maxFlour)
                {
                    maxFlour = flour;
                }
                if (sugar > maxSugar)
                {
                    maxSugar = sugar;
                }

                totalNeededFlour += flour;
                totalNeededSugar += sugar;
            }

            double totalFlourPackages = Math.Ceiling(totalNeededFlour / flourPackage);
            double totalSugarPackages = Math.Ceiling(totalNeededSugar / sugatPackage);

            Console.WriteLine($"Sugar: {totalSugarPackages}");
            Console.WriteLine($"Flour: {totalFlourPackages}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
