using System;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double totalSum = 0;

            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    totalSum = 30 * nights;
                }
                else if (dates == "24-27")
                {
                    totalSum = 35 * nights;
                }
                else if (dates == "28-31")
                {
                    totalSum = 40 * nights;
                }
            }
            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    totalSum = 28 * nights;
                }
                else if (dates == "24-27")
                {
                    totalSum = 32 * nights;
                }
                else if (dates == "28-31")
                {
                    totalSum = 39 * nights;
                }
            }
            else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    totalSum = 32 * nights;
                }
                else if (dates == "24-27")
                {
                    totalSum = 37 * nights;
                }
                else if (dates == "28-31")
                {
                    totalSum = 43 * nights;
                }
            }

            Console.WriteLine($"Easter trip to {destination} : {totalSum:f2} leva.");
        }
    }
}
