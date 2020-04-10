using System;

namespace TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());

            double totalMoneyEarned = 0;
            int daysWon = 0;
            int daysLose = 0;

            for (int i = 1; i <= tournamentDays; i++)
            {
                int winCounter = 0;
                int loseCounter = 0;
                double dailyMoney = 0;

                string sport = Console.ReadLine();
                while (sport != "Finish")
                {
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        dailyMoney += 20;
                        winCounter++;
                    }
                    else
                    {
                        loseCounter++;
                    }
                    sport = Console.ReadLine();
                }

                if (winCounter > loseCounter)
                {
                    dailyMoney = dailyMoney + (dailyMoney * 0.10);
                    daysWon++;
                }
                else
                {
                    daysLose++;
                }
                totalMoneyEarned += dailyMoney;
            }

            if (daysWon > daysLose)
            {
                totalMoneyEarned = totalMoneyEarned + (totalMoneyEarned * 0.20);
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoneyEarned:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoneyEarned:f2}");
            }
        }
    }
}
