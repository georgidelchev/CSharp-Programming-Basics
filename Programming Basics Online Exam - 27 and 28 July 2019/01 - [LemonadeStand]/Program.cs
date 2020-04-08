using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double lemonsKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            double waterLiters = double.Parse(Console.ReadLine());

            double lemonJuiceInMl = lemonsKg * 980;
            double totalLemonade = lemonJuiceInMl + waterLiters * 1000 + (sugarKg * 0.30);
            double cupsSold = Math.Floor(totalLemonade / 150);
            double totalSum = cupsSold * 1.20;

            Console.WriteLine($"All cups sold: {cupsSold}");
            Console.WriteLine($"Money earned: {totalSum:f2}");
        }
    }
}
