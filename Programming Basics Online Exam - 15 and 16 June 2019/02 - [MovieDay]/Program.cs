using System;

namespace MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int scenesNumber = int.Parse(Console.ReadLine());
            int scenesTime = int.Parse(Console.ReadLine());

            double terrainPrepare = time * 0.15;
            double totalTime = scenesNumber * scenesTime + terrainPrepare;

            if (time >= totalTime)
            {
                double timeLeft = time - totalTime;
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeLeft)} minutes left!");
            }
            else if (totalTime > time)
            {
                double timeNeeded = totalTime - time;
                Console.WriteLine($"Time is up! To complete the movie you need {timeNeeded} minutes.");
            }
        }
    }
}
