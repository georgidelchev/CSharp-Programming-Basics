using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int serieTime = int.Parse(Console.ReadLine());
            int restTime = int.Parse(Console.ReadLine());

            double lunchTime = restTime * 1.00 / 8;
            double restingTime = restTime * 1.00 / 4;

            double timeLeft = restTime - lunchTime - restingTime;

            if (timeLeft >= serieTime)
            {
                double leftTime = timeLeft - serieTime;
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(leftTime)} minutes free time.");
            }
            else if (serieTime > timeLeft)
            {
                double timeNeeded = serieTime - timeLeft;
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeNeeded)} more minutes.");
            }
        }
    }
}
