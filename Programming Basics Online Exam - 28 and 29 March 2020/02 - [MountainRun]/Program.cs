using System;

namespace MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentRecord = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timePerMeterInSeconds = double.Parse(Console.ReadLine());

            double neededTime = distanceInMeters * timePerMeterInSeconds;
            double slowingTime = Math.Floor((distanceInMeters / 50)) * 30;
            double totalTimeNeeded = neededTime + slowingTime;

            if (totalTimeNeeded >= currentRecord)
            {
                double timeNeeded = totalTimeNeeded - currentRecord;
                Console.WriteLine($"No! He was {timeNeeded:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {totalTimeNeeded:f2} seconds. ");
            }
        }
    }
}
