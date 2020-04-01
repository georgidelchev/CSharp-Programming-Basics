using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int seriesNumber = int.Parse(Console.ReadLine());

            double totalSum = 0;

            for (int i = 0; i < seriesNumber; i++)
            {
                string serieName = Console.ReadLine();
                double seriePrice = double.Parse(Console.ReadLine());
                if (serieName == "Thrones")
                {
                    totalSum = totalSum + (seriePrice - seriePrice * 0.50);
                }
                else if (serieName == "Lucifer")
                {
                    totalSum = totalSum + (seriePrice - seriePrice * 0.40);
                }
                else if (serieName == "Protector")
                {
                    totalSum = totalSum + (seriePrice - seriePrice * 0.30);
                }
                else if (serieName == "TotalDrama")
                {
                    totalSum = totalSum + (seriePrice - seriePrice * 0.20);
                }
                else if (serieName == "Area")
                {
                    totalSum = totalSum + (seriePrice - seriePrice * 0.10);
                }
                else
                {
                    totalSum += seriePrice;
                }
            }

            if (totalSum > budget)
            {
                Console.WriteLine($"You need {totalSum - budget:f2} lv. more to buy the series!");

            }
            else if (budget >= totalSum)
            {
                Console.WriteLine($"You bought all the series and left with {budget - totalSum:f2} lv.");
            }

        }
    }
}
