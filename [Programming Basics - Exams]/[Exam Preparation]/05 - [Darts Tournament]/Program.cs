using System;

namespace DartsTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());
            int totalMovesCounter = 0;
            while (startingPoints > 0)
            {
                string sector = Console.ReadLine();
                totalMovesCounter++;
                if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {totalMovesCounter} moves!");
                    break;
                }
                int hittedPoints = int.Parse(Console.ReadLine());
                if (sector == "number section")
                {
                    startingPoints -= hittedPoints;
                }
                else if (sector == "double ring")
                {
                    startingPoints -= hittedPoints * 2;
                }
                else if (sector == "triple ring")
                {
                    startingPoints -= hittedPoints * 3;
                }
                if (startingPoints < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(0 - startingPoints)}.");
                    break;
                }
            }

            if (startingPoints == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {totalMovesCounter} moves! ");
            }
        }
    }
}
