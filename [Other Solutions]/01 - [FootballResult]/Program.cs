using System;

namespace FootballResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int win = 0;
            int lost = 0;
            int draw = 0;
            int totalGamesPlayed = 3;

            for (int i = 1; i <= totalGamesPlayed; i++)
            {
                string result = Console.ReadLine();
                if (result[0] > result[2])
                {
                    win++;
                }
                else if (result[0] < result[2])
                {
                    lost++;
                }
                else
                {
                    draw++;
                }


            }
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn games: {draw}");
        }
    }
}
