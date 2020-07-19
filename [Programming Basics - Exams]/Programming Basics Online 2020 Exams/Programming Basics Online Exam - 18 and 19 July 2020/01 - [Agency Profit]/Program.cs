using System;

namespace AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int adultsTicketsCount = int.Parse(Console.ReadLine());
            int childsTicketsCount = int.Parse(Console.ReadLine());
            double adultsTicketsPrice = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double childTicketsPrice = adultsTicketsPrice - (adultsTicketsPrice * 0.70) + tax;
            adultsTicketsPrice += tax;

            double totalPrice = adultsTicketsCount * adultsTicketsPrice + childsTicketsCount * childTicketsPrice;
            double profit = totalPrice * 0.20;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {profit:f2} lv.");
        }
    }
}
