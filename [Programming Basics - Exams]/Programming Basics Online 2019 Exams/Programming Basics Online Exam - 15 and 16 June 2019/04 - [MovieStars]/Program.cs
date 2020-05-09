using System;

namespace MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double currentBudget = budget;

            while (true)
            {
                double salary = 0;
                string name = Console.ReadLine();
                if (name == "ACTION")
                {
                    Console.WriteLine($"We are left with {currentBudget:f2} leva.");
                    break;
                }
                if (name.Length > 15)
                {                  
                    salary = currentBudget * 0.20;
                }
                else
                {                   
                    salary = double.Parse(Console.ReadLine());
                }
                if (salary > currentBudget)
                {
                    Console.WriteLine($"We need {Math.Abs(currentBudget-salary):f2} leva for our actors.");
                    break;
                }
                currentBudget -= salary;
               
            }
        }
    }
}
