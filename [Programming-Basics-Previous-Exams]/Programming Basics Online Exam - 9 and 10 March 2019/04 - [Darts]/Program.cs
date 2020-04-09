using System;

namespace DartsTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int currentPoints = 301;
            int totalShots = 0;
            int unsuccessfulShots = 0;
            string field = Console.ReadLine();
            while ((currentPoints != 0) && (field != "Retire"))
            {
                int points = int.Parse(Console.ReadLine());

                if (field == "Single")
                {
                    if (currentPoints >= points)
                    {
                        currentPoints = currentPoints - points;
                        totalShots++;
                    }
                    else
                    {
                        unsuccessfulShots++;
                    }
                }
                else if (field == "Double")
                {
                    if (currentPoints >= (points * 2))
                    {
                        currentPoints = currentPoints - points * 2;
                        totalShots++;
                    }
                    else
                    {
                        unsuccessfulShots++;
                    }
                }
                else if (field == "Triple")
                {
                    if (currentPoints >= (points * 3))
                    {
                        currentPoints = currentPoints - points * 3;
                        totalShots++;
                    }
                    else
                    {
                        unsuccessfulShots++;
                    }
                }
                else if (field == "Retire")
                {
                    Console.WriteLine($"{playerName} retired after {unsuccessfulShots} unsuccessful shots.");
                    break;
                }
                field = Console.ReadLine();
            }
            if (currentPoints == 0)
            {
                Console.WriteLine($"{playerName} won the leg with {totalShots} shots.");
            }
            else if (field == "Retire")
            {
                Console.WriteLine($"{playerName} retired after {unsuccessfulShots} unsuccessful shots.");
            }
        }
    }
}
