using System;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string classCar = string.Empty;
            string carType = string.Empty;
            double price = 0;

            if (budget <= 100)
            {
                classCar = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = budget * 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                classCar = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = budget * 0.80;
                }
            }
            else if (budget > 500)
            {
                classCar = "Luxury class";
                carType = "Jeep";
                price = budget * 0.90;
            }

            Console.WriteLine($"{classCar}");
            Console.WriteLine($"{carType} - {price:f2}");
        }
    }
}
