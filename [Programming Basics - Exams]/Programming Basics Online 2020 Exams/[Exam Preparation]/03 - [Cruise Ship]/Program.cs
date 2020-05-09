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

            int familyCount = 4;
            double totalPrice = 0;
            switch (cruiseType)
            {
                case "Mediterranean":
                    switch (cabinType)
                    {
                        case "standard cabin":
                            totalPrice = 27.50;
                            break;
                        case "cabin with balcony":
                            totalPrice = 30.20;
                            break;
                        case "apartment":
                            totalPrice = 40.50;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Adriatic":
                    switch (cabinType)
                    {
                        case "standard cabin":
                            totalPrice = 22.99;
                            break;
                        case "cabin with balcony":
                            totalPrice = 25.00;
                            break;
                        case "apartment":
                            totalPrice = 34.99;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Aegean":
                    switch (cabinType)
                    {
                        case "standard cabin":
                            totalPrice = 23.00;
                            break;
                        case "cabin with balcony":
                            totalPrice = 26.60;
                            break;
                        case "apartment":
                            totalPrice = 39.80;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            
            totalPrice *= nightsCount * familyCount;
            if (nightsCount > 7)
            {
                totalPrice *= 0.75;
            }

            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {totalPrice:f2} lv.");
        }
    }
}
