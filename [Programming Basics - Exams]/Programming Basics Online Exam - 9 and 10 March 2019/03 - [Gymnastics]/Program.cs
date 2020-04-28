using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string device = Console.ReadLine();

            double totalPoints = 0;


            if (country == "Russia")
            {
                if (device == "ribbon")
                {
                    totalPoints = 9.100 + 9.400;
                }
                else if (device == "hoop")
                {
                    totalPoints = 9.300 + 9.800;
                }
                else if (device == "rope")
                {
                    totalPoints = 9.600 + 9.000;
                }
            }
            else if (country == "Bulgaria")
            {
                if (device == "ribbon")
                {
                    totalPoints = 9.600 + 9.400;
                }
                else if (device == "hoop")
                {
                    totalPoints = 9.550 + 9.750;
                }
                else if (device == "rope")
                {
                    totalPoints = 9.500 + 9.400;
                }
            }
            else if (country == "Italy")
            {
                if (device == "ribbon")
                {
                    totalPoints = 9.200 + 9.500;
                }
                else if (device == "hoop")
                {
                    totalPoints = 9.450 + 9.350;
                }
                else if (device == "rope")
                {
                    totalPoints = 9.700 + 9.150;
                }
            }


            Console.WriteLine($"The team of {country} get {totalPoints:f3} on {device}.");
            Console.WriteLine($"{((20 - totalPoints) / 20) * 100:f2}%");

        }
    }
}
