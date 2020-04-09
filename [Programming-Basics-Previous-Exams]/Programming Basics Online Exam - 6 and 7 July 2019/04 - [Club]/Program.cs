using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double wantedProfit = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            double order = 0;

            while (true)
            {
                string cocktailName = Console.ReadLine();
                if (cocktailName == "Party!")
                {
                    Console.WriteLine($"We need {wantedProfit - order:f2} leva more.");
                    Console.WriteLine($"Club income - {order:f2} leva.");
                    break;
                }
                int cocktailsNumber = int.Parse(Console.ReadLine());
                totalPrice = (cocktailName.Length * cocktailsNumber);
                if (totalPrice % 2 != 0)
                {
                    totalPrice = totalPrice - (totalPrice * 0.25);
                }

                order = order + totalPrice;

                if (order >= wantedProfit)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {order:f2} leva.");
                    break;
                }
            }
        }
    }
}
