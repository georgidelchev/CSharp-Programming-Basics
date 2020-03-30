using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            double totalSumHand = 0;
            double totalSumCard = 0;
            double totalSum = 0;
            int handCounter = 0;
            int cardCounter = 0;
            while (true)
            {
                string handPay1 = Console.ReadLine();
                if (handPay1 == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }
                double handPay = double.Parse(handPay1);

                if (handPay > 100)
                {
                    Console.WriteLine("Error in transaction!");
                }
                else
                {
                    Console.WriteLine("Product sold!");
                    totalSumHand = totalSumHand + handPay;
                    totalSum = totalSum + handPay;
                    handCounter++;
                }

                string cardPay1 = Console.ReadLine();
                if (cardPay1 == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }
                double cardPay = double.Parse(cardPay1);
                if (cardPay < 10)
                {
                    Console.WriteLine("Error in transaction!");
                }
                else
                {
                    Console.WriteLine("Product sold!");
                    totalSumCard = totalSumCard + cardPay;
                    totalSum = totalSum + cardPay;
                    cardCounter++;
                }

                if (totalSum >= sum)
                {
                    Console.WriteLine($"Average CS: {totalSumHand / handCounter:f2}");
                    Console.WriteLine($"Average CC: {totalSumCard / cardCounter:f2}");
                    break;
                }
            }
        }
    }
}
