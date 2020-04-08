using System;

namespace BestPlaneTicket
{
    class Program
    {
        static void Main(string[] args)
        {

            string ticketNumber = Console.ReadLine();
            double ticketPrice = double.Parse(Console.ReadLine());
            int minutesOnTheBoard = int.Parse(Console.ReadLine());

            int currentBestMinutes = int.MaxValue;
            string currentFlight = ticketNumber;
            double currentPrice = 0;
            
            int hours = 0;
            int minutes = 0;

            while (ticketNumber != "End")
            {
                if (minutesOnTheBoard < currentBestMinutes)
                {
                    currentFlight = ticketNumber;
                    currentBestMinutes = minutesOnTheBoard;
                    currentPrice = ticketPrice;

                    hours = currentBestMinutes;
                    minutes = currentBestMinutes;
                }

                ticketNumber = Console.ReadLine();
                if (ticketNumber == "End")
                {
                    continue;
                }
                
                ticketPrice = double.Parse(Console.ReadLine());
                minutesOnTheBoard = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Ticket found for flight {currentFlight} costs {(currentPrice * 1.96):f2} leva with {hours/60}h {minutes%60}m stay");
        }
    }
}
