using System;

namespace FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            
            double totalSum = 0;

            if (gender == 'm')
            {
                if (sport == "Gym")
                {
                    totalSum = 42;
                }
                else if (sport == "Boxing")
                {
                    totalSum = 41;
                }
                else if (sport == "Yoga")
                {
                    totalSum = 45;
                }
                else if (sport == "Zumba")
                {
                    totalSum = 34;
                }
                else if (sport == "Dances")
                {
                    totalSum = 51;
                }
                else if (sport == "Pilates")
                {
                    totalSum = 39;
                }
            }
            else if (gender == 'f')
            {
                if (sport == "Gym")
                {
                    totalSum = 35;
                }
                else if (sport == "Boxing")
                {
                    totalSum = 37;
                }
                else if (sport == "Yoga")
                {
                    totalSum = 42;
                }
                else if (sport == "Zumba")
                {
                    totalSum = 31;
                }
                else if (sport == "Dances")
                {
                    totalSum = 53;
                }
                else if (sport == "Pilates")
                {
                    totalSum = 37;
                }
            }

            if (age <= 19)
            {
                totalSum = totalSum - (totalSum * 0.20);
            }

            if (money >= totalSum)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                double moneyNeeded = totalSum - money;
                Console.WriteLine($"You don't have enough money! You need ${moneyNeeded:f2} more.");
            }
        
        }
    }
}
