using System;

namespace BakingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int participantsInTheCompetitionCount = int.Parse(Console.ReadLine());

            double totalSumForCharity = 0;
            int totalBakeryCounter = 0;
            for (int i = 1; i <= participantsInTheCompetitionCount; i++)
            {
                int bakedCookiesCount = 0;
                int bakedCakesCount = 0;
                int bakedWafflesCount = 0;
                string participantName = Console.ReadLine();
                string sweetType = Console.ReadLine();
                while (sweetType != "Stop baking!")
                {
                    int bakedCount = int.Parse(Console.ReadLine());
                    if (sweetType == "cookies")
                    {
                        bakedCookiesCount += bakedCount;
                    }
                    else if (sweetType == "cakes")
                    {
                        bakedCakesCount += bakedCount;
                    }
                    else if (sweetType == "waffles")
                    {
                        bakedWafflesCount += bakedCount;
                    }
                    totalBakeryCounter += bakedCount;
                    sweetType = Console.ReadLine();
                }
                totalSumForCharity += bakedCookiesCount * 1.50 + bakedCakesCount * 7.80 + bakedWafflesCount * 2.30;
                Console.WriteLine($"{participantName} baked {bakedCookiesCount} cookies, {bakedCakesCount} cakes and {bakedWafflesCount} waffles.");
            }
            Console.WriteLine($"All bakery sold: {totalBakeryCounter}");
            Console.WriteLine($"Total sum for charity: {totalSumForCharity:f2} lv.");
        }
    }
}
