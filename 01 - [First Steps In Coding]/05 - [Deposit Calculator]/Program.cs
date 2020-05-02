using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposidSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double increasePerMonth = (deposidSum * (percent / 100)) / 12;
            double totalSum = deposidSum + (months * increasePerMonth);

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
