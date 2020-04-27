using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double hallArea = length * 100 * width * 100;
            double benchArea = hallArea / 10; 
            double wardrobeArea = wardrobeSide * 100 * wardrobeSide * 100;

            int spaceForOneDancer = 40;
            int spaceForMoving = 7000;

            double totalFreeSpace = hallArea - benchArea - wardrobeArea;
            double totalDancers = totalFreeSpace / (spaceForOneDancer + spaceForMoving);

            Console.WriteLine(Math.Floor(totalDancers));
        }
    }
}
