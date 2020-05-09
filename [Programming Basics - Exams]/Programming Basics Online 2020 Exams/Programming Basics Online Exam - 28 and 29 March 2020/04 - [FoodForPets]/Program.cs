using System;

namespace FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            double totalFoodQty = double.Parse(Console.ReadLine());

            double dogEaten = 0;
            double catEaten = 0;
            double totalFood = 0;
            double totalBiscuits = 0;

            for (int i = 1; i <= daysCount; i++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());

                double dailyFood = 0;
                double biscuitCount = 0;

                if (i % 3 == 0)
                {
                    dailyFood = dogFood + catFood;
                    biscuitCount = dailyFood * 0.10;
                    totalBiscuits += biscuitCount;
                }

                dogEaten += dogFood;
                catEaten += catFood;
                totalFood += (dogFood + catFood);
            }

            double totalEatenFood = (totalFood / totalFoodQty) * 100;
            double totalDogEaten = (dogEaten / totalFood) * 100;
            double totalCatEaten = (catEaten / totalFood) * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuits)}gr.");
            Console.WriteLine($"{totalEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalDogEaten:f2}% eaten from the dog.");
            Console.WriteLine($"{totalCatEaten:f2}% eaten from the cat.");

        }
    }
}
