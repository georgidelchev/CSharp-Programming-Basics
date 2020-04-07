using System;

namespace TailorWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int rectangleTables = int.Parse(Console.ReadLine());
            double lengthRectangleTable = double.Parse(Console.ReadLine());
            double widthRectangleTable = double.Parse(Console.ReadLine());

            double totalArea = rectangleTables * (lengthRectangleTable + 2 * 0.30) * (widthRectangleTable + 2 * 0.30);
            double totalAreaK = rectangleTables * (lengthRectangleTable / 2) * (lengthRectangleTable / 2);

            double priceUSD = totalArea * 7 + totalAreaK * 9;
            double priceBGN = priceUSD * 1.85;

            Console.WriteLine($"{priceUSD:f2}" + " USD");
            Console.WriteLine($"{priceBGN:f2}" + " BGN");


        }
    }
}

