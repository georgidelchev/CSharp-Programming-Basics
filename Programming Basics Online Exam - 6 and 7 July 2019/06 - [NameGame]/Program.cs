using System;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int bestPoints = 0;
            string currentWinner = "";

            while (name != "Stop")
            {
                int points = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num == name[i])
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }
                if (points >= bestPoints)
                {
                    bestPoints = points;
                    currentWinner = name;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {currentWinner} with {bestPoints} points!");
        }
    }
}
