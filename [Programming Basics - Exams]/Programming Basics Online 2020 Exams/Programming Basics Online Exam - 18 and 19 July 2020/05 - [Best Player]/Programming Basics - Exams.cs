using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName;

            string bestPlayerName = string.Empty;
            int bestGoals = 0;

            while ((playerName = Console.ReadLine()) != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (goals > bestGoals)
                {
                    bestGoals = goals;
                    bestPlayerName = playerName;
                }

                if (goals >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{bestPlayerName} is the best player!");

            if (bestGoals >= 3)
            {
                Console.WriteLine($"He has scored {bestGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestGoals} goals.");
            }
        }
    }
}
