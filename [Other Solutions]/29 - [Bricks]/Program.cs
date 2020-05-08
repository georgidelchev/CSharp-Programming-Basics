using System;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int bricksCount = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int cartVolume = int.Parse(Console.ReadLine());

            int totalBricks = workersCount * cartVolume;
            double courses = Math.Ceiling((double)bricksCount / totalBricks);
            Console.WriteLine(courses);
        }
    }
}
