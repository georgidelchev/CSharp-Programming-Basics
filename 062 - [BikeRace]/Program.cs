using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();

            double juniorsPrice = 0;
            double seniorsPrice = 0;
            double totalPrice = 0;

            if (track == "trail")
            {
                juniorsPrice = 5.50;
                seniorsPrice = 7.00;
            }
            else if (track == "cross-country")
            {
                juniorsPrice = 8.00;
                seniorsPrice = 9.50;
                if (juniors + seniors >= 50)
                {
                    juniorsPrice = juniorsPrice - (juniorsPrice * 0.25);
                    seniorsPrice = seniorsPrice - (seniorsPrice * 0.25);
                }
            }
            else if (track == "downhill")
            {
                juniorsPrice = 12.25;
                seniorsPrice = 13.75;
            }
            else if (track == "road")
            {
                juniorsPrice = 20.00;
                seniorsPrice = 21.50;
            }

            totalPrice = (juniors * juniorsPrice) + (seniors * seniorsPrice);
            double totalPriceAfterExpenses = totalPrice - (totalPrice * 0.05);
            Console.WriteLine($"{totalPriceAfterExpenses:f2}");
        }
    }
}
