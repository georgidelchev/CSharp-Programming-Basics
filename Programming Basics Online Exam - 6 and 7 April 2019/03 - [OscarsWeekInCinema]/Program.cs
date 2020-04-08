using System;

namespace OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string hallType = Console.ReadLine();
            int ticketsBought = int.Parse(Console.ReadLine());

            double totalSum = 0;

            if (movieName == "A Star Is Born")
            {
                if (hallType == "normal")
                {
                    totalSum = 7.50 * ticketsBought;
                }
                else if (hallType == "luxury")
                {
                    totalSum = 10.50 * ticketsBought;
                }
                else if (hallType == "ultra luxury")
                {
                    totalSum = 13.50 * ticketsBought;
                }
            }
            else if (movieName == "Bohemian Rhapsody")
            {
                if (hallType == "normal")
                {
                    totalSum = 7.35 * ticketsBought;
                }
                else if (hallType == "luxury")
                {
                    totalSum = 9.45 * ticketsBought;
                }
                else if (hallType == "ultra luxury")
                {
                    totalSum = 12.75 * ticketsBought;
                }
            }
            else if (movieName == "Green Book")
            {
                if (hallType == "normal")
                {
                    totalSum = 8.15 * ticketsBought;
                }
                else if (hallType == "luxury")
                {
                    totalSum = 10.25 * ticketsBought;
                }
                else if (hallType == "ultra luxury")
                {
                    totalSum = 13.25 * ticketsBought;
                }
            }
            else if (movieName == "The Favourite")
            {
                if (hallType == "normal")
                {
                    totalSum = 8.75 * ticketsBought;
                }
                else if (hallType == "luxury")
                {
                    totalSum = 11.55 * ticketsBought;
                }
                else if (hallType == "ultra luxury")
                {
                    totalSum = 13.95 * ticketsBought;
                }
            }

            Console.WriteLine($"{movieName} -> {totalSum:f2} lv.");
        }
    }
}
