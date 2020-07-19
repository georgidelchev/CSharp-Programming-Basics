using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int ballsCount = int.Parse(Console.ReadLine());

            int totalPoints = 0;

            int redPoints = 0;
            int orangePoints = 0;
            int yellowPoints = 0;
            int whitePoints = 0;
            int blackPoints = 0;
            int otherColors = 0;

            for (int i = 0; i < ballsCount; i++)
            {
                string ballType = Console.ReadLine();

                if (ballType == "red")
                {
                    totalPoints += 5;
                    redPoints++;
                }
                else if (ballType == "orange")
                {
                    totalPoints += 10;
                    orangePoints++;
                }
                else if (ballType == "yellow")
                {
                    totalPoints += 15;
                    yellowPoints++;
                }
                else if (ballType == "white")
                {
                    totalPoints += 20;
                    whitePoints++;
                }
                else if (ballType == "black")
                {
                    totalPoints /= 2;
                    blackPoints++;
                }
                else
                {
                    otherColors++;
                }
            }

            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {redPoints}");
            Console.WriteLine($"Points from orange balls: {orangePoints}");
            Console.WriteLine($"Points from yellow balls: {yellowPoints}");
            Console.WriteLine($"Points from white balls: {whitePoints}");
            Console.WriteLine($"Other colors picked: {otherColors}");
            Console.WriteLine($"Divides from black balls: {blackPoints}");
        }
    }
}
