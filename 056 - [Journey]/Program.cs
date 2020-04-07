using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            double totalSum = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    totalSum = budget * 0.30;
                }
                else if (season == "winter")
                {
                    totalSum = budget * 0.70;
                }
            }
            else if (budget <= 1000 && budget > 100)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    totalSum = budget * 0.40;
                }
                else if (season == "winter")
                {
                    totalSum = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                totalSum = budget * 0.90;
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"Hotel - {totalSum:f2}");
            }

            if (season == "summer" && (destination == "Bulgaria" || destination == "Balkans"))
            {
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"Camp - {totalSum:f2}");
            }
            else if (season == "winter" && (destination == "Bulgaria" || destination == "Balkans"))
            {
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"Hotel - {totalSum:f2}");
            }


        }
    }
}
