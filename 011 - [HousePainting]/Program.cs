using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double houseHeight = double.Parse(Console.ReadLine());
            double lengthOfTheSideWall = double.Parse(Console.ReadLine());
            double heightOfTheRectangleRoofWall = double.Parse(Console.ReadLine());

            double sideWallArea = houseHeight * lengthOfTheSideWall;
            double windowSize = 1.5 * 1.5;
            double twoOfTheWalls = sideWallArea * 2 - windowSize * 2;
            double backWall = houseHeight * houseHeight;
            double doorSize = 1.2 * 2;
            double frontAndBehindWalls = 2 * backWall - doorSize;

            double totalWallSize = twoOfTheWalls + frontAndBehindWalls;
            double greenPaint = totalWallSize / 3.4;

            double twoOfRectanglesOfTheRoof = 2 * (houseHeight * lengthOfTheSideWall);
            double twoOfRectangles = 2 * (houseHeight * heightOfTheRectangleRoofWall / 2);
            double totalArea = twoOfRectanglesOfTheRoof + twoOfRectangles;
            double redPaint = totalArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
