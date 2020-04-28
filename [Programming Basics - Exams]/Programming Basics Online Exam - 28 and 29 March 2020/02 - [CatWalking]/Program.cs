using System;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalking = int.Parse(Console.ReadLine());
            int dailyWalkings = int.Parse(Console.ReadLine());
            int kcalTaken = int.Parse(Console.ReadLine()) / 2;

            int totalKcal = ((dailyWalkings * minutesWalking) * 5);

            if (totalKcal >= kcalTaken)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalKcal}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalKcal}.");
            }
        }
    }
}
