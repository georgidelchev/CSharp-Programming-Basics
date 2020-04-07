using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = string.Empty;
            double totalPrice = 0;
            string destination = string.Empty;

            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    totalPrice = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    totalPrice = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    totalPrice = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    totalPrice = budget * 0.60;
                }
            }
            else if (budget > 3000)
            {
                place = "Hotel";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    totalPrice = budget * 0.90;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    totalPrice = budget * 0.90;
                }
            }

            Console.WriteLine($"{destination} - {place} - {totalPrice:f2}");
        }
    }
}
