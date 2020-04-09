using System;

namespace MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketsPrice = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double ticketsPricePerDay = tickets * ticketsPrice;
            double totalProfit = days * ticketsPricePerDay;
            double percentForCinema = (totalProfit * percent * 1.00) / 100;
            double profit = totalProfit - percentForCinema;
            Console.WriteLine($"The profit from the movie {movieName} is {profit:f2} lv.");
        }
    }
}
