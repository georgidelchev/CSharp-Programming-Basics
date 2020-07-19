using System;

namespace AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceAbove20Kilos = double.Parse(Console.ReadLine());
            double kilosOfLuggage = double.Parse(Console.ReadLine());
            int daysToTheTravel = int.Parse(Console.ReadLine());
            int luggagesCount = int.Parse(Console.ReadLine());

            double luggageCurrentPrice = 0;

            if (kilosOfLuggage < 10)
            {
                luggageCurrentPrice = priceAbove20Kilos * 0.20;
            }
            else if (kilosOfLuggage >= 10 && kilosOfLuggage <= 20)
            {
                luggageCurrentPrice = priceAbove20Kilos * 0.50;
            }
            else if (kilosOfLuggage > 20)
            {
                luggageCurrentPrice = priceAbove20Kilos;
            }

            if (daysToTheTravel > 30)
            {
                luggageCurrentPrice += luggageCurrentPrice * 0.10;
            }
            else if (daysToTheTravel >= 7 && daysToTheTravel <= 30)
            {
                luggageCurrentPrice += luggageCurrentPrice * 0.15;
            }
            else if (daysToTheTravel < 7)
            {
                luggageCurrentPrice += luggageCurrentPrice * 0.40;
            }

            double totalPrice = luggageCurrentPrice * luggagesCount;

            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
        }
    }
}
