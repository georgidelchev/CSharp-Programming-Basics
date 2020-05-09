using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int incomePerMonth = int.Parse(Console.ReadLine());
            int monthsCount = int.Parse(Console.ReadLine());
            double neededMoney = double.Parse(Console.ReadLine());

            double moneySheNeeds = incomePerMonth * 0.30;
            double savedMoneyPerMonth = incomePerMonth - (neededMoney + moneySheNeeds);
            double totalSavedMoney = monthsCount * savedMoneyPerMonth;

            Console.WriteLine($"She can save {(savedMoneyPerMonth / incomePerMonth * 1.00) * 100:f2}%");
            Console.WriteLine($"{totalSavedMoney:f2}");
        }
    }
}
