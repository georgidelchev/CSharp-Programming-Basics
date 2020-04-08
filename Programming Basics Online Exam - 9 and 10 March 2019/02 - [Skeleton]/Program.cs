using System;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int secondsPer100m = int.Parse(Console.ReadLine());

            int totalSeconds = minutes * 60 + seconds;
            double slowingTime = length / 120;
            double totalSlowingTime = slowingTime * 2.5;
            double marinsTime = (length / 100) * secondsPer100m - totalSlowingTime;
            if (totalSeconds >= marinsTime)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {marinsTime:f3}.");
            }
            else if (marinsTime > totalSeconds)
            {
                Console.WriteLine($"No, Marin failed! He was {Math.Abs(totalSeconds - marinsTime):f3} second slower.");
            }
        }
    }
}
