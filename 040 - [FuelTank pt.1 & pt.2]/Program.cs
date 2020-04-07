using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litersInTank = double.Parse(Console.ReadLine());



            if (litersInTank >= 25)
            {
                if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas")
                {
                    Console.WriteLine($"You have enough {fuelType.ToLower()}.");
                }
                else
                {
                    Console.WriteLine("Invalid fuel!");
                }
            }
            else if (litersInTank < 25)
            {
                if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas")
                {
                    Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
                }
                else
                {
                    Console.WriteLine("Invalid fuel!");
                }
            }

        }
    }
}
