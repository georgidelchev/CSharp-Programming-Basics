using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double taxiStartingPrice = 0.70;
            double taxiPrice = 0;
            double busPrice = 0;
            double trainPrice = 0;

            if (km < 20)
            {
                if (dayOrNight == "day")
                {
                    taxiPrice = taxiStartingPrice + (km * 0.79);
                    Console.WriteLine($"{taxiPrice:f2}");
                }
                else if (dayOrNight == "night")
                {
                    taxiPrice = taxiStartingPrice + (km * 0.90);
                    Console.WriteLine($"{taxiPrice:f2}");
                }
            }
            else if (km >= 100)
            {
                if (dayOrNight == "day" || dayOrNight == "night")
                {
                    trainPrice = 0.06 * km;
                }
            }
            else if (km >= 20)
            {
                if (dayOrNight == "day" || dayOrNight == "night")
                {
                    busPrice = 0.09 * km;
                }
            }


            if (busPrice > trainPrice)
            {
                Console.WriteLine($"{busPrice:f2}");
            }
            else if (trainPrice > busPrice)
            {
                Console.WriteLine($"{trainPrice:f2}");
            }
        }
    }
}
