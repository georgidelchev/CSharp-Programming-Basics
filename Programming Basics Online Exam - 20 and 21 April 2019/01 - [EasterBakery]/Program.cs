using System;

namespace EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPricePerKg = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int may = int.Parse(Console.ReadLine());

            double sugarPricePerKg = flourPricePerKg - (flourPricePerKg * 0.25);
            double eggsPrice = flourPricePerKg + (flourPricePerKg * 0.10);
            double mayPrice = sugarPricePerKg - (sugarPricePerKg * 0.80);

            double totalSum = flourPricePerKg * flourKg + sugarPricePerKg * sugarKg + eggsPrice * eggs + mayPrice * may;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
