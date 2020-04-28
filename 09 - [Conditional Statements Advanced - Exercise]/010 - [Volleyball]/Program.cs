using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidayNumbersAtTheYear = int.Parse(Console.ReadLine());
            int weekendsThatVladiTravels = int.Parse(Console.ReadLine());

            int totalWeekends = 48;
            int totalWeekendsAtSofia = totalWeekends - weekendsThatVladiTravels;
            double saturdayGamesAtSofiq = totalWeekendsAtSofia * 0.75;
            int WeekendsAtHomeTown = weekendsThatVladiTravels;

            double gamesAtHolidays = holidayNumbersAtTheYear * 0.6667;
            double totalGames = saturdayGamesAtSofiq + WeekendsAtHomeTown + gamesAtHolidays;

            double percentForYear = 0;

            if (year == "leap")
            {
                percentForYear = 0.15 * totalGames;
                totalGames = totalGames + percentForYear;
            }

            Console.WriteLine($"{Math.Floor(totalGames)}");
        }
    }
}
