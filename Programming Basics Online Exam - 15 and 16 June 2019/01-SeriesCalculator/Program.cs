using System;

namespace SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double countdownWithoutAds = double.Parse(Console.ReadLine());

            double adsPerEpisode = countdownWithoutAds * 0.20;
            double episodeWithAds = countdownWithoutAds + adsPerEpisode;
            double totalExtraTime = seasons * 10;
            double totalTime = Math.Floor(episodeWithAds * episodes * seasons + totalExtraTime);
            Console.WriteLine($"Total time needed to watch the {name} series is {totalTime} minutes.");
        }
    }
}
