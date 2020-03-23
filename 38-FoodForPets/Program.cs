using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOutCount = int.Parse(Console.ReadLine());
            int leftFoodInKg = int.Parse(Console.ReadLine());
            double dogFoodInKgPerDay = double.Parse(Console.ReadLine());
            double catFoodInKgPerDay = double.Parse(Console.ReadLine());
            double turtleFoodInGrPerDay = double.Parse(Console.ReadLine());

            double foodForDog = daysOutCount * dogFoodInKgPerDay;
            double foodForCat = daysOutCount * catFoodInKgPerDay;
            double foodForTurtle = daysOutCount * (turtleFoodInGrPerDay / 1000);

            double totalFoodNeeded = foodForDog + foodForCat + foodForTurtle;

            if (totalFoodNeeded <= leftFoodInKg)
            {
                double foodLeft = leftFoodInKg - totalFoodNeeded;
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else if (leftFoodInKg < totalFoodNeeded)
            {
                double foodNeeded = totalFoodNeeded - leftFoodInKg;
                Console.WriteLine($"{Math.Ceiling(foodNeeded)} more kilos of food are needed.");
            }
        }
    }
}
