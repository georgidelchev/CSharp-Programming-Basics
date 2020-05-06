using System;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = double.Parse(Console.ReadLine());

            double bathPrice = smallestRoomArea / 2;
            double secondRoomArea = smallestRoomArea + (smallestRoomArea * 0.10);
            double thirdRoomArea = secondRoomArea + (secondRoomArea * 0.10);

            double totalArea = smallestRoomArea + kitchenArea + secondRoomArea + thirdRoomArea + bathPrice;
            totalArea += (totalArea * 0.05);
            Console.WriteLine($"{totalArea * pricePerSquareMeter:f2}");
        }
    }
}
