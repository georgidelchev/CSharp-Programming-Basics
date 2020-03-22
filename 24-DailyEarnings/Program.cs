using System;

namespace DailyEarnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            double moneyEarnedPerDay = double.Parse(Console.ReadLine());
            double dollarToLevCourse = double.Parse(Console.ReadLine());

            double monthlySalary = workingDays * moneyEarnedPerDay;
            double earningsPerYear = monthlySalary * 12 + monthlySalary * 2.5; // 2.5 is bonus
            double tax = earningsPerYear * 0.25;
            double clearEarnings = earningsPerYear - tax;
            double dollarToLev = clearEarnings * dollarToLevCourse;
            double averageEarningsPerDay = dollarToLev / 365;

            Console.WriteLine($"{averageEarningsPerDay:f2}");
        }
    }
}
