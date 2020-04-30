using System;

namespace CruiseGames
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfThePlayer = Console.ReadLine();
            int playedGamesCount = int.Parse(Console.ReadLine());

            double volleyballAveragePoints = 0;
            double tennisAveragePoints = 0;
            double badmintonAveragePoints = 0;

            int volleyballGamesCounter = 0;
            int tennisGamesCounter = 0;
            int badmintonGamesCounter = 0;

            double volleyballCheck = 0;
            double tennisCheck = 0;
            double badmintonCheck = 0;
            for (int i = 1; i <= playedGamesCount; i++)
            {
                string nameOfTheGame = Console.ReadLine();
                int gamePointsCount = int.Parse(Console.ReadLine());

                if (nameOfTheGame == "volleyball")
                {
                    double volleyballPoints = gamePointsCount + (gamePointsCount * 0.07);
                    volleyballCheck += volleyballPoints;
                    volleyballGamesCounter++;
                }
                else if (nameOfTheGame == "tennis")
                {
                    double tennisPoints = gamePointsCount + (gamePointsCount * 0.05);
                    tennisCheck += tennisPoints;
                    tennisGamesCounter++;
                }
                else if (nameOfTheGame == "badminton")
                {
                    double badmintonPoints = gamePointsCount + (gamePointsCount * 0.02);
                    badmintonCheck += badmintonPoints;
                    badmintonGamesCounter++;
                }
            }

            volleyballAveragePoints = volleyballCheck / volleyballGamesCounter;
            tennisAveragePoints = tennisCheck / tennisGamesCounter;
            badmintonAveragePoints = badmintonCheck / badmintonGamesCounter;

            double totalPoints = Math.Floor(volleyballCheck + tennisCheck + badmintonCheck);

            if ((volleyballAveragePoints >= 75) &&
                (tennisAveragePoints >= 75) &&
                (badmintonAveragePoints >= 75))
            {
                Console.WriteLine($"Congratulations, {nameOfThePlayer}! You won the cruise games with {totalPoints} points. ");
            }
            else
            {
                Console.WriteLine($"Sorry, {nameOfThePlayer}, you lost. Your points are only {totalPoints}.");
            }
        }
    }
}
