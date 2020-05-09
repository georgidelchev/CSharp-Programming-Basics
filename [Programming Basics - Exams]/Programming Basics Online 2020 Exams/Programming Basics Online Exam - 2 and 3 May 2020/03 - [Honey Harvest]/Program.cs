using System;

namespace HoneyHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double totalHoneyProduced = 0;
            if (season == "Spring")
            {
                if (flowerType == "Sunflower")
                {
                    totalHoneyProduced = 10;
                }
                else if (flowerType == "Daisy")
                {
                    totalHoneyProduced = 12;
                    totalHoneyProduced += totalHoneyProduced * 0.10;
                }
                else if (flowerType == "Lavender")
                {
                    totalHoneyProduced = 12;
                }
                else if (flowerType == "Mint")
                {
                    totalHoneyProduced = 10;
                    totalHoneyProduced += totalHoneyProduced * 0.10;
                }
            }
            else if (season == "Summer")
            {
                if (flowerType == "Sunflower" || flowerType == "Daisy" || flowerType == "Lavender")
                {
                    totalHoneyProduced = 8;
                }
                else if (flowerType == "Mint")
                {
                    totalHoneyProduced = 12;
                }
                totalHoneyProduced += totalHoneyProduced * 0.10;
            }
            else if (season == "Autumn")
            {
                if (flowerType == "Sunflower")
                {
                    totalHoneyProduced = 12;
                }
                else if (flowerType == "Daisy" || flowerType == "Lavender" || flowerType == "Mint")
                {
                    totalHoneyProduced = 6;
                }
                totalHoneyProduced -= totalHoneyProduced * 0.05;
            }
            Console.WriteLine($"Total honey harvested: {totalHoneyProduced * flowersCount:f2}");
        }
    }
}
