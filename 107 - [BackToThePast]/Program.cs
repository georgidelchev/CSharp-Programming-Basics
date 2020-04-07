using System;
using System.Threading;
namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int ageCounter = 18;
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= 12000 + (ageCounter * 50);
                }
                ageCounter++;

            }
            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
        }
    }
}