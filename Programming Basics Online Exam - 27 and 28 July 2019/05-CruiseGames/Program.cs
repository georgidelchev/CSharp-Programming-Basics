using System;

namespace CruiseGames
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());

            int v = 0;
            int t = 0;
            int b = 0;
            double volleyballPoints1 = 0;
            double tennisPoints1 = 0;
            double badmintonPoints1 = 0;
            double volleyballAverage = 0;
            double tennisAverage = 0;
            double badmintonAverage = 0;

            for (int i = 1; i <= gamesPlayed; i++)
            {
                string gameName = Console.ReadLine();
                int gamePoints = int.Parse(Console.ReadLine());

                if (gameName == "volleyball")
                {
                    double volleyballPoints = gamePoints + (gamePoints * 0.07);
                    volleyballPoints1 += volleyballPoints;

                    v++;
                }
                else if (gameName == "tennis")
                {
                    double tennisPoints = gamePoints + (gamePoints * 0.05);
                    tennisPoints1 += tennisPoints;

                    t++;
                }
                else if (gameName == "badminton")
                {
                    double badmintonPoints = gamePoints + (gamePoints * 0.02);
                    badmintonPoints1 += badmintonPoints;

                    b++;
                }
            }

            volleyballAverage = Math.Floor(volleyballPoints1 / v);
            tennisAverage = Math.Floor(tennisPoints1 / t);
            badmintonAverage = Math.Floor(badmintonPoints1 / b);

            if (volleyballAverage >= 75 && tennisAverage >= 75 && badmintonAverage >= 75)
            {
                Console.WriteLine($"Congratulations, {playerName}! You won the cruise games with {Math.Floor(volleyballPoints1 + tennisPoints1 + badmintonPoints1)} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {playerName}, you lost. Your points are only {Math.Floor(volleyballPoints1 + tennisPoints1 + badmintonPoints1)}.");
            }
        }
    }
}
