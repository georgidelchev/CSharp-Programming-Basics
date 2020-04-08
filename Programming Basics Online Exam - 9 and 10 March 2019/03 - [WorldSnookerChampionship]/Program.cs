using System;

namespace WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournamentStage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());

            double totalSum = 0;

            if (tournamentStage == "Quarter final")
            {
                if (ticketType == "Standard")
                {
                    totalSum = 55.50 * ticketsCount;
                }
                else if (ticketType == "Premium")
                {
                    totalSum = 105.20 * ticketsCount;
                }
                else if (ticketType == "VIP")
                {
                    totalSum = 118.90 * ticketsCount;
                }
            }
            else if (tournamentStage == "Semi final")
            {
                if (ticketType == "Standard")
                {
                    totalSum = 75.88 * ticketsCount;
                }
                else if (ticketType == "Premium")
                {
                    totalSum = 125.22 * ticketsCount;
                }
                else if (ticketType == "VIP")
                {
                    totalSum = 300.40 * ticketsCount;
                }
            }
            else if (tournamentStage == "Final")
            {
                if (ticketType == "Standard")
                {
                    totalSum = 110.10 * ticketsCount;
                }
                else if (ticketType == "Premium")
                {
                    totalSum = 160.66 * ticketsCount;
                }
                else if (ticketType == "VIP")
                {
                    totalSum = 400 * ticketsCount;
                }
            }
            bool pictures = true;
            if (totalSum > 4000)
            {
                totalSum = totalSum - (totalSum * 0.25);
                pictures = false;
            }
            else if (totalSum >= 2500)
            {
                totalSum = totalSum - (totalSum * 0.10);
            }

            if (pictures == true && picture == 'Y')
            {
                totalSum = totalSum + (ticketsCount * 40);
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
