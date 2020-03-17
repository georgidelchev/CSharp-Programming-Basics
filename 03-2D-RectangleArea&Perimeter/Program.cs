using System;

namespace SoftUniTas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRectangleTables = int.Parse(Console.ReadLine());
            double rectangleTablesLength = double.Parse(Console.ReadLine());
            double rectangleTablesWidth = double.Parse(Console.ReadLine());

            double totalCoverArea = numberOfRectangleTables * (rectangleTablesLength + 2 * 0.30) * (rectangleTablesWidth + 2 * 0.30);
            double totalCareArea = numberOfRectangleTables * (rectangleTablesLength / 2) * (rectangleTablesWidth / 2);

            double priceInDollars = totalCoverArea * 7 + totalCareArea * 9;
            double priceInLev = priceInDollars * 1.85;

            Console.WriteLine($"{priceInDollars:f2} USD");
            Console.WriteLine($"{priceInLev:f2} BGN");
        }
    }
}
