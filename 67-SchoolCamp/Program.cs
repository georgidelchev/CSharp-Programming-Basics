using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsNumber = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;
            double discount = 0;
            string sportType = string.Empty;

            if (season == "Winter")
            {
                if (groupType == "boys")
                {
                    pricePerNight = 9.60;
                    sportType = "Judo";
                }
                else if (groupType == "girls")
                {
                    pricePerNight = 9.60;
                    sportType = "Gymnastics";
                }
                else if (groupType == "mixed")
                {
                    pricePerNight = 10.00;
                    sportType = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (groupType == "boys")
                {
                    pricePerNight = 7.20;
                    sportType = "Tennis";
                }
                else if (groupType == "girls")
                {
                    pricePerNight = 7.20;
                    sportType = "Athletics";
                }
                else if (groupType == "mixed")
                {
                    pricePerNight = 9.50;
                    sportType = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (groupType == "boys")
                {
                    pricePerNight = 15.00;
                    sportType = "Football";
                }
                else if (groupType == "girls")
                {
                    pricePerNight = 15.00;
                    sportType = "Volleyball";
                }
                else if (groupType == "mixed")
                {
                    pricePerNight = 20.00;
                    sportType = "Swimming";
                }
            }


            if (studentsNumber >= 50)
            {
                discount = 0.50;
            }
            else if (studentsNumber >= 20 && studentsNumber < 50)
            {
                discount = 0.15;
            }
            else if (studentsNumber >= 10 && studentsNumber < 20)
            {
                discount = 0.05;
            }

            double totalSum = pricePerNight * nights * studentsNumber;
            double discountedPrice = totalSum - (totalSum * discount);

            Console.WriteLine($"{sportType} {discountedPrice:f2}");
        }
    }
}
