using System;

namespace CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodBought = int.Parse(Console.ReadLine());
            int foodInKilos = foodBought * 1000;
            double totalEatenFood = 0;

            string command = Console.ReadLine();
            while (command != "Adopted")
            {
                int eatenFood = int.Parse(command);
                totalEatenFood += eatenFood;
                command = Console.ReadLine();
            }

            if (foodInKilos >= totalEatenFood)
            {
                double foodLeft = foodInKilos - totalEatenFood;
                Console.WriteLine($"Food is enough! Leftovers: {foodLeft} grams. ");
            }
            else
            {
                double neededFood = totalEatenFood - foodInKilos;
                Console.WriteLine($"Food is not enough. You need {neededFood} grams more.");
            }
        
        }
    }
}
