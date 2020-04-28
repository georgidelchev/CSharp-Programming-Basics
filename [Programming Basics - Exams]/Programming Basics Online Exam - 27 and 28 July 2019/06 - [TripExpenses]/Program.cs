using System;

namespace TripExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeAtTheTrip = int.Parse(Console.ReadLine());

            double moneyLeft = 0;
            for (int i = 0; i < timeAtTheTrip; i++)
            {
                double startingMoney = 60 + moneyLeft;
                moneyLeft = 0;
                string inputCommand = Console.ReadLine();
                int productsCount = 0;

                while (inputCommand != "Day over")
                {
                    double productPrice = Convert.ToDouble(inputCommand);
                    if (startingMoney - productPrice >= 0)
                    {
                        startingMoney -= productPrice;
                        productsCount++;
                    }
                    else
                    {
                        inputCommand = Console.ReadLine();
                        continue;
                    }
                    if (startingMoney == 0)
                    {
                        break;
                    }
                    inputCommand = Console.ReadLine();
                }
                if (inputCommand == "Day over")
                {
                    moneyLeft = Math.Abs(moneyLeft - startingMoney);
                    Console.WriteLine($"Money left from today: {moneyLeft:f2}. You've bought {productsCount} products.");
                }
                else
                {
                    Console.WriteLine($"Daily limit exceeded! You've bought {productsCount} products.");
                }
            }
        }
    }
}
