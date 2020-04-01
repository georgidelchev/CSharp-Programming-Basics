using System;

namespace FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string clubName = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());

            int win = 0;
            int points = 0;
            int draw = 0;
            int lose = 0;

            if (gamesPlayed == 0)
            {
                Console.WriteLine($"{clubName} hasn't played any games during this season.");
            }
            else
            {
                for (int i = 0; i < gamesPlayed; i++)
                {
                    string result = Console.ReadLine();
                    if (result == "W")
                    {
                        win++;
                        points += 3;
                    }
                    else if (result == "D")
                    {
                        draw++;
                        points += 1;
                    }
                    else if (result == "L")
                    {
                        lose++;
                    }
                }
                Console.WriteLine($"{clubName} has won {points} points during this season");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {win}");
                Console.WriteLine($"## D: {draw}");
                Console.WriteLine($"## L: {lose}");

                Console.WriteLine($"Win rate: {(win * 1.00 / gamesPlayed * 1.00) * 100:f2}%");
            }

        }
    }
}
