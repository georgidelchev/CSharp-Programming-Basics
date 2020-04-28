using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            int shipRentAtSpring = 3000;
            int shipRentAtAutumnAndSummer = 4200;
            int shipRentAtWinter = 2600;

            double totalSum = 0;
            double discount = 0;

            switch (season)
            {
                case "Spring":
                    totalSum = shipRentAtSpring;
                    break;
                case "Summer":
                    totalSum = shipRentAtAutumnAndSummer;
                    break;
                case "Autumn":
                    totalSum = shipRentAtAutumnAndSummer;
                    break;
                case "Winter":
                    totalSum = shipRentAtWinter;
                    break;
                default:
                    break;
            }
            
            if (fishermenCount <= 6)
            {
                discount = totalSum * 0.10;
                totalSum = totalSum - discount;
            }
            else if (fishermenCount >= 7 && fishermenCount <= 11)
            {
                discount = totalSum * 0.15;
                totalSum = totalSum - discount;
            }
            else if (fishermenCount >= 12)
            {
                discount = totalSum * 0.25;
                totalSum = totalSum - discount;
            }
            
            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                double discountTwo = totalSum * 0.05;
                totalSum = totalSum - discountTwo;
            }

            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (totalSum > budget)
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
