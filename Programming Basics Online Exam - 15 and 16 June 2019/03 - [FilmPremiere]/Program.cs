using System;

namespace FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string extras = Console.ReadLine();
            int ticketsNumber = int.Parse(Console.ReadLine());

            double totalSum = 0;

            if (movieName == "John Wick")
            {
                if (extras == "Drink")
                {
                    totalSum = ticketsNumber * 12.00;
                }
                else if (extras == "Popcorn")
                {
                    totalSum = ticketsNumber * 15.00;
                }
                else if (extras == "Menu")
                {
                    totalSum = ticketsNumber * 19.00;
                }
            }
            else if (movieName == "Star Wars")
            {
                if (extras == "Drink")
                {
                    totalSum = ticketsNumber * 18.00;
                }
                else if (extras == "Popcorn")
                {
                    totalSum = ticketsNumber * 25.00;
                }
                else if (extras == "Menu")
                {
                    totalSum = ticketsNumber * 30.00;
                }
                if (ticketsNumber >= 4)
                {
                    totalSum = totalSum - (totalSum * 0.30);
                }
            }
            else if (movieName == "Jumanji")
            {
                if (extras == "Drink")
                {
                    totalSum = ticketsNumber * 9.00;
                }
                else if (extras == "Popcorn")
                {
                    totalSum = ticketsNumber * 11.00;
                }
                else if (extras == "Menu")
                {
                    totalSum = ticketsNumber * 14.00;
                }
                if (ticketsNumber == 2)
                {
                    totalSum = totalSum - (totalSum * 0.15);
                }
            }
            Console.WriteLine($"Your bill is {totalSum:f2} leva.");
        }
    }
}
