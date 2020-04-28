using System;

namespace NewTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLength = int.Parse(Console.ReadLine());

            double timeForOneTile = 0.2;

            double area = length * length;
            double benchArea = benchWidth * benchLength;
            double tileArea = tileWidth * tileLength;

            double neededArea = area - benchArea;
            double tilesNeeded = neededArea / tileArea;

            double totalNeededTime = tilesNeeded * timeForOneTile;

            Console.WriteLine(tilesNeeded);
            Console.WriteLine(totalNeededTime);
        }
    }
}
