using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double totalSum = 0;

            if (season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                {
                    totalSum = kmPerMonth * 0.75;
                }
                else if (5000 < kmPerMonth && kmPerMonth < 10000)
                {
                    totalSum = kmPerMonth * 0.95;
                }
            }
            else if (season == "Summer")
            {
                if (kmPerMonth <= 5000)
                {
                    totalSum = kmPerMonth * 0.90;
                }
                else if (5000 < kmPerMonth && kmPerMonth < 10000)
                {
                    totalSum = kmPerMonth * 1.10;
                }
            }
            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                {
                    totalSum = kmPerMonth * 1.05;
                }
                else if (5000 < kmPerMonth && kmPerMonth < 10000)
                {
                    totalSum = kmPerMonth * 1.25;
                }
            }
            
            if (10000 < kmPerMonth && kmPerMonth <= 20000)
            {
                totalSum = kmPerMonth * 1.45;
            }
            totalSum = totalSum * 4; //months
            double sumAfterExpenses = totalSum - (totalSum * 0.10);
            Console.WriteLine($"{sumAfterExpenses:f2}");
        }
    }
}
