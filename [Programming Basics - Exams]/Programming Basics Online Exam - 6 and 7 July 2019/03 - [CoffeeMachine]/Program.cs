using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int drinksCount = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            double discount = 0;

            if (drink == "Espresso")
            {
                if (drinksCount >= 5)
                {
                    discount = 0.25;
                }
                if (sugar == "Without")
                {
                    totalPrice = drinksCount * 0.90;
                    totalPrice = totalPrice - (totalPrice * 0.35);
                    totalPrice = totalPrice - (totalPrice * discount);
                }
                else if (sugar == "Normal")
                {
                    totalPrice = drinksCount * 1.00;
                    totalPrice = totalPrice - (totalPrice * discount);
                }
                else if (sugar == "Extra")
                {
                    totalPrice = drinksCount * 1.20;
                    totalPrice = totalPrice - (totalPrice * discount);
                }
            }
            else if (drink == "Cappuccino")
            {                
                if (sugar == "Without")
                {
                    totalPrice = drinksCount * 1.00;
                    totalPrice = totalPrice - (totalPrice * 0.35);
                }
                else if (sugar == "Normal")
                {
                    totalPrice = drinksCount * 1.20;
                }
                else if (sugar == "Extra")
                {
                    totalPrice = drinksCount * 1.60;
                }
            }
            else if (drink == "Tea")
            {
                if (sugar == "Without")
                {
                    totalPrice = drinksCount * 0.50;
                    totalPrice = totalPrice - (totalPrice * 0.35);
                }
                else if (sugar == "Normal")
                {
                    totalPrice = drinksCount * 0.60;
                }
                else if (sugar == "Extra")
                {
                    totalPrice = drinksCount * 0.70;
                }
            }

            if (totalPrice > 15)
            {
                totalPrice = totalPrice - (totalPrice * 0.20);
            }
            Console.WriteLine($"You bought {drinksCount} cups of {drink} for {totalPrice:f2} lv.");
        }
    }
}
