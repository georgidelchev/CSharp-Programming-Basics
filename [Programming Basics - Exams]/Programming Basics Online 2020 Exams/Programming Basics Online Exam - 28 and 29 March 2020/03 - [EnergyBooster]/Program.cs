using System;

namespace EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int orderCount = int.Parse(Console.ReadLine());


            double totalSum = 0;

            if (size == "small")
            {
                if (fruit == "Watermelon")
                {
                    totalSum = 56 * 2;
                }
                else if (fruit == "Mango")
                {
                    totalSum = 36.66 * 2;
                }
                else if (fruit == "Pineapple")
                {
                    totalSum = 42.10 * 2;
                }
                else if (fruit == "Raspberry")
                {
                    totalSum = 20 * 2;
                }
            }
            else if (size == "big")
            {
                if (fruit == "Watermelon")
                {
                    totalSum = 28.70 * 5;
                }
                else if (fruit == "Mango")
                {
                    totalSum = 19.60 * 5;
                }
                else if (fruit == "Pineapple")
                {
                    totalSum = 24.80 * 5;
                }
                else if (fruit == "Raspberry")
                {
                    totalSum = 15.20 * 5;
                }
            }

            totalSum *= orderCount;

            if (totalSum >= 400 && totalSum <= 1000)
            {
                totalSum = totalSum - (totalSum * 0.15);
            }
            else if (totalSum > 1000)
            {
                totalSum = totalSum - (totalSum * 0.50);
            }

            Console.WriteLine($"{totalSum:f2} lv.");

        }
    }
}
