using System;

namespace LuggageTax
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();

            double volume = width * heigth * depth;
            double tax = 0;
            if (volume <= 50)
            {

            }
            else if (volume > 50)
            {
                if (ticketType == "true" && volume > 50 && volume <= 100)
                {

                }
                else if (ticketType == "false" && volume > 50 && volume <= 100)
                {
                    tax = 25;
                }

                else if (ticketType == "true" && volume > 100 && volume <= 200)
                {
                    tax = 10;
                }
                else if (ticketType == "false" && volume > 100 && volume <= 200)
                {
                    tax = 50;
                }
                else if (ticketType == "true" && volume > 200 && volume <= 300)
                {
                    tax = 20;
                }
                else if (ticketType == "false" && volume > 200 && volume <= 300)
                {
                    tax = 100;
                }

            }
            Console.WriteLine($"Luggage tax: {tax:f2}");
        }
    }
}
