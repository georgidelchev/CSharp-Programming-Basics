using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysInTheHotel = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double roomForOnePerson = 18.00;
            double apartment = 25.00;
            double presidentApartment = 35.00;

            int totalEvenings = daysInTheHotel - 1;
            double discount = 0;
            double totalSum = 0;
            if (roomType == "room for one person")
            {
                totalSum = totalEvenings * roomForOnePerson;
            }
            else if (roomType == "apartment")
            {
                totalSum = totalEvenings * apartment;
                if (daysInTheHotel < 10)
                {
                    discount = totalSum * 0.30;
                }
                else if (daysInTheHotel >= 10 && daysInTheHotel <= 15)
                {
                    discount = totalSum * 0.35;
                }
                else if (daysInTheHotel > 15)
                {
                    discount = totalSum * 0.50;
                }
            }
            else if (roomType == "president apartment")
            {
                totalSum = totalEvenings * presidentApartment;
                if (daysInTheHotel < 10)
                {
                    discount = totalSum * 0.10;
                }
                else if (daysInTheHotel >= 10 && daysInTheHotel <= 15)
                {
                    discount = totalSum * 0.15;
                }
                else if (daysInTheHotel > 15)
                {
                    discount = totalSum * 0.20;
                }
            }

            totalSum = totalSum - discount;


            if (feedback == "positive")
            {
                totalSum = totalSum + (totalSum * 0.25);
            }
            else if (feedback == "negative")
            {
                totalSum = totalSum - (totalSum * 0.10);
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
