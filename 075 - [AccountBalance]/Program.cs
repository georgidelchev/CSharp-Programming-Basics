using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int paymentsCount = int.Parse(Console.ReadLine());

            int payments = 0;
            double totalSum = 0;
            while (payments < paymentsCount)
            {
                double moneyIn = double.Parse(Console.ReadLine());
                if (moneyIn < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {moneyIn:f2}");
                totalSum += moneyIn;
                payments++;
            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
