using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            double totalPoints = startingPoints;
            double averagePoints = 0;
            double percentWon = 0;

            for (int i = 0; i < tournamentsCount; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    totalPoints = totalPoints + 2000;
                    averagePoints = averagePoints + 2000;
                    percentWon++;
                }
                else if (stage == "F")
                {
                    totalPoints = totalPoints + 1200;
                    averagePoints = averagePoints + 1200;
                }
                else if (stage == "SF")
                {
                    totalPoints = totalPoints + 720;
                    averagePoints = averagePoints + 720;
                }
            }
            averagePoints = Math.Floor(averagePoints / tournamentsCount);
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{(percentWon / tournamentsCount) * 100:f2}%");
        }
    }
}
