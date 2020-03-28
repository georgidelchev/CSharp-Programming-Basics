using System;

namespace DartsTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointsNumber = int.Parse(Console.ReadLine());
            string sector = Console.ReadLine();
            int hittedPoints = int.Parse(Console.ReadLine());

            int currentPoints = pointsNumber;
            int moves = 0;

            while (currentPoints >= 0)
            {

                if (sector == "number section")
                {
                    currentPoints -= hittedPoints;
                }
                else if (sector == "double ring")
                {
                    currentPoints = currentPoints - hittedPoints * 2;
                }
                else if (sector == "triple ring")
                {
                    currentPoints = currentPoints - hittedPoints * 3;
                }
                moves++;
                sector = Console.ReadLine();
                
                if (sector == "bullseye")
                {
                    moves++;
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {moves} moves!");
                    
                    break;
                }

                if (currentPoints == 0)
                {
                    Console.WriteLine($"Congratulations! You won the game in {moves} moves!");
                    break;                    
                }

                hittedPoints = int.Parse(Console.ReadLine());
            }
            if (currentPoints < 0)
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(currentPoints)}.");
            }

        }
    }
}
