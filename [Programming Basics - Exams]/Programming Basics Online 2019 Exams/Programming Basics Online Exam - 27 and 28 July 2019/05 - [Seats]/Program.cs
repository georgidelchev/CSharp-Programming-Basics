using System;

namespace ConcertticketSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            int boughtedTickets = int.Parse(Console.ReadLine());

            for (int i = 0; i < boughtedTickets; i++)
            {
                string boughtedTicketsNumber = Console.ReadLine();
                int ticketLength = boughtedTicketsNumber.Length;
                string ticketSeatsTranslated = " ";

                if (ticketLength == 4)
                {
                    char firstCharOfTheTicket = boughtedTicketsNumber[0];
                    if (firstCharOfTheTicket >= 'A' && firstCharOfTheTicket <= 'Z')
                    {
                        ticketSeatsTranslated = ticketSeatsTranslated + firstCharOfTheTicket;
                    }
                    else
                    {
                        ticketSeatsTranslated = ticketSeatsTranslated + boughtedTicketsNumber[3];
                    }
                    ticketSeatsTranslated += boughtedTicketsNumber[1];
                    ticketSeatsTranslated += boughtedTicketsNumber[2];
                }
                else if (ticketLength == 6 || ticketLength == 5)
                {
                    ticketSeatsTranslated += boughtedTicketsNumber[0];
                    ticketSeatsTranslated += (int)boughtedTicketsNumber[1];
                }
                Console.WriteLine($"Seat decoded:{ticketSeatsTranslated}");
            }

        }

    }
}

