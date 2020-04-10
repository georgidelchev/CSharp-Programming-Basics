using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pensCount = int.Parse(Console.ReadLine());
            int markersCount = int.Parse(Console.ReadLine());
            double cleaningStuffLiters = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double totalSum = pensCount * 5.80 + markersCount * 7.20 + cleaningStuffLiters * 1.20;
            double totalSumWithDiscount = totalSum - (totalSum * percentDiscount / 100);
            Console.WriteLine($"{totalSumWithDiscount:f3}");
        }
    }
}
