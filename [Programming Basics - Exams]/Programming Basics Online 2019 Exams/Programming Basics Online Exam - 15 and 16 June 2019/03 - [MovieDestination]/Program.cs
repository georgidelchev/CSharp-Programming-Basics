using System;

namespace MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double totalSum = 0;

            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    totalSum = days * 45000;
                }
                else if (season == "Summer")
                {
                    totalSum = days * 40000;
                }
                totalSum = totalSum - (totalSum * 0.30);
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    totalSum = days * 17000;
                }
                else if (season == "Summer")
                {
                    totalSum = days * 12500;
                }
                totalSum = totalSum + (totalSum * 0.25);
            }
            else if (destination == "London")
            {
                if (season == "Winter")
                {
                    totalSum = days * 24000;
                }
                else if (season == "Summer")
                {
                    totalSum = days * 20250;
                }
            }

            if (movieBudget >= totalSum)
            {
                double moneyLeft = movieBudget - totalSum;
                Console.WriteLine($"The budget for the movie is enough! We have {moneyLeft:f2} leva left! ");
            }
            else if (totalSum > movieBudget)
            {
                double moneyNeeded = totalSum - movieBudget;
                Console.WriteLine($"The director needs {moneyNeeded:f2} leva more!");
            }
        }
    }
}
