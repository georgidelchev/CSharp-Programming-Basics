using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int charityDays = int.Parse(Console.ReadLine());
            int confectionersCount = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int wafflesCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            int cakePrice = 45;
            double wafflesPrice = 5.80;
            double pancakesPrice = 3.20;

            int moneyFromCakesPerDay = cakesCount * cakePrice;
            double moneyFromWafflesPerDay = wafflesCount * wafflesPrice;
            double moneyFromPancakesPerDay = pancakesCount * pancakesPrice;

            double sum = (moneyFromCakesPerDay + moneyFromWafflesPerDay + moneyFromPancakesPerDay) * confectionersCount;
            double totalSum = sum * charityDays;
            double clearSum = totalSum - (totalSum / 8); // 1/8 from totalSum goes for expenses!

            Console.WriteLine($"{clearSum:f2}");
        }
    }
}
