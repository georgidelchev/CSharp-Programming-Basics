using System;

namespace SleepingTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());

            int playingInRestDays = restDays * 127; // minutes
            int playingInWorkingDays = 365 - restDays;
            playingInWorkingDays *= 63;
            int totalMinutesPlayed = playingInRestDays + playingInWorkingDays;

            int hours = 0;
            int minutes = 0;

            if (totalMinutesPlayed > 30000)
            {
                int timePlus = totalMinutesPlayed - 30000;
                hours = Math.Abs(timePlus / 60);
                minutes = Math.Abs(timePlus % 60);
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else if (totalMinutesPlayed <= 30000)
            {
                int timeLeft = totalMinutesPlayed - 30000;
                hours = Math.Abs(timeLeft / 60);
                minutes = Math.Abs(timeLeft % 60);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} less for play");
            }
        }
    }
}
