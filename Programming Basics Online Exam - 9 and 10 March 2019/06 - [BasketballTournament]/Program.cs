using System;

namespace BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournamentName = Console.ReadLine();

            double ourWinPoints = 0;
            double ourLosePoints = 0;
            double totalMatches = 0;

            while (tournamentName != "End of tournaments")
            {
                int tournamentMatches = int.Parse(Console.ReadLine());
                for (int i = 1; i <= tournamentMatches; i++)
                {
                    int ourTeamPoints = int.Parse(Console.ReadLine());
                    int enemyTeamPoints = int.Parse(Console.ReadLine());
                    if (ourTeamPoints > enemyTeamPoints)
                    {
                        ourWinPoints++;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {ourTeamPoints - enemyTeamPoints} points.");
                    }
                    else if (enemyTeamPoints > ourTeamPoints)
                    {
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {enemyTeamPoints - ourTeamPoints} points.");
                        ourLosePoints++;
                    }
                }
                totalMatches += tournamentMatches;
                tournamentName = Console.ReadLine();
            }
            if (tournamentName == "End of tournaments")
            {
                Console.WriteLine($"{(ourWinPoints / totalMatches) * 100:f2}% matches win");
                Console.WriteLine($"{(ourLosePoints / totalMatches) * 100:f2}% matches lost");
            }
        }
    }
}
