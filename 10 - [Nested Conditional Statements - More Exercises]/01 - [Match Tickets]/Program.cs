using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleNumber = int.Parse(Console.ReadLine());

            double transportPrice = 0;
            double vipTicket = 499.99;
            double normalTicket = 249.99;
            double totalSumForTickets = 0;
            double totalSum = 0;

            if (peopleNumber >= 1 && peopleNumber <= 4)
            {
                transportPrice = 0.75 * budget;
            }
            else if (peopleNumber >= 5 && peopleNumber <= 9)
            {
                transportPrice = 0.60 * budget;
            }
            else if (peopleNumber >= 10 && peopleNumber <= 24)
            {
                transportPrice = 0.50 * budget;
            }
            else if (peopleNumber >= 25 && peopleNumber <= 49)
            {
                transportPrice = 0.40 * budget;
            }
            else if (peopleNumber >= 50)
            {
                transportPrice = 0.25 * budget;
            }

            if (category == "VIP")
            {
                totalSumForTickets = peopleNumber * vipTicket;
                
            }
            else if (category == "Normal")
            {
                totalSumForTickets = peopleNumber * normalTicket;

            }

            totalSum = transportPrice + totalSumForTickets;

            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (totalSum > budget)
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
