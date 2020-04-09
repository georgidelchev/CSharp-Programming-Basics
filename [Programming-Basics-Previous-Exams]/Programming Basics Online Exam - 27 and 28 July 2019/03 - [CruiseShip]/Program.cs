using System;

namespace CruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine();
            string cabinType = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double standardCabin = 0;
            double cabinWithBalcony = 0;
            double apartment = 0;

            double totalSum = 0;
            double discount = 0;

            if (cruiseType == "Mediterranean")
            {
                standardCabin = 27.50;
                cabinWithBalcony = 30.20;
                apartment = 40.50;
            }
            else if (cruiseType == "Adriatic")
            {
                standardCabin = 22.99;
                cabinWithBalcony = 25.00;
                apartment = 34.99;
            }
            else if (cruiseType == "Aegean")
            {
                standardCabin = 23.00;
                cabinWithBalcony = 26.60;
                apartment = 39.80;
            }

            if (cabinType == "standard cabin")
            {
                totalSum = nightsCount * 4 * standardCabin;
            }
            else if (cabinType == "cabin with balcony")
            {
                totalSum = nightsCount * 4 * cabinWithBalcony;
            }
            else if (cabinType == "apartment")
            {
                totalSum = nightsCount * 4 * apartment;
            }

            if (nightsCount > 7)
            {
                discount = 0.25;
                totalSum = totalSum - (totalSum * discount);
            }

            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {totalSum:f2} lv.");
        }
    }
}
