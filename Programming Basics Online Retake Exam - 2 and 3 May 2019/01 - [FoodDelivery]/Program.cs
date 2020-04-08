using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegMenus = int.Parse(Console.ReadLine());

            double totalSumOfMenus = chickenMenus * 10.35 + fishMenus * 12.40 + vegMenus * 8.15;
            double dessertPrice = totalSumOfMenus * 0.20;
            double totalPrice = totalSumOfMenus + dessertPrice + 2.50; //delivery is 2.50

            Console.WriteLine($"Total: {totalPrice:f2}");
        }
    }
}
