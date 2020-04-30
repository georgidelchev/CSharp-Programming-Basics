using System;

namespace SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double bathrobePrice = double.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            double umrellaPrice = bathrobePrice * 2 / 3;
            double flipflopsPrice = umrellaPrice * 0.75;
            double bagPrice = (bathrobePrice + flipflopsPrice) / 3;
            double totalPrice = umrellaPrice + flipflopsPrice + bagPrice + bathrobePrice;
            double totalPriceAfterDiscount = totalPrice - (totalPrice * (discountPercent * 1.00 / 100));

            if (budget >= totalPriceAfterDiscount)
            {
                double moneyLeft = budget - totalPriceAfterDiscount;
                Console.WriteLine($"Annie's sum is {totalPriceAfterDiscount:f2} lv. She has {moneyLeft:f2} lv. left.");
            }
            else
            {
                double moneyNeeded = totalPriceAfterDiscount - budget;
                Console.WriteLine($"Annie's sum is {totalPriceAfterDiscount:f2} lv. She needs {moneyNeeded:f2} lv. more.");
            }
        }
    }
}
