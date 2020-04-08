using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double litersFuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double totalSum = litersFuel * 2.10 + 100;
            if (day == "Saturday")
            {
                totalSum = totalSum - (totalSum * 0.10);
            }
            else if (day == "Sunday")
            {
                totalSum = totalSum - (totalSum * 0.20);
            }

            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
            }
            else
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
            }
        }
    }
}
