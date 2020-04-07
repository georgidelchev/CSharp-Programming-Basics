using System;

namespace FishMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPricePerKg = double.Parse(Console.ReadLine());
            double spratPricePerKg = double.Parse(Console.ReadLine());
            double chamoisKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            int musselsKg = int.Parse(Console.ReadLine());

            double chamoisPricePerKg = chamoisKg * (mackerelPricePerKg + mackerelPricePerKg * 0.60);
            double scadPricePerKg = scadKg * (spratPricePerKg + spratPricePerKg * 0.80);
            double musselsPricePerKg = musselsKg * 7.50;

            double totalPrice = chamoisPricePerKg + scadPricePerKg + musselsPricePerKg;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
