using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomePerMonth = int.Parse(Console.ReadLine());
            int numberOfMonthsToSaveMoney = int.Parse(Console.ReadLine());
            double neededMoney = double.Parse(Console.ReadLine());

            double money = incomePerMonth * 0.30;
            double sumToSave = incomePerMonth - (neededMoney + money);
            double totalSum = numberOfMonthsToSaveMoney * sumToSave;
            double percent = sumToSave / incomePerMonth;

            Console.WriteLine($"She can save {percent*100:f2}%");
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
