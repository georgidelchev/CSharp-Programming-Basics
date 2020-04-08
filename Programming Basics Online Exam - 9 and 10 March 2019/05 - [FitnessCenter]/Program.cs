using System;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitorsCount = int.Parse(Console.ReadLine());


            int backCount = 0;
            int chestCount = 0;
            int legsCount = 0;
            int absCount = 0;
            int proteinShakeCount = 0;
            int proteinBarCount = 0;
            double workout = 0;
            double buying = 0;


            for (int i = 0; i < visitorsCount; i++)
            {
                string working = Console.ReadLine();

                if (working == "Back")
                {
                    backCount++;
                    workout++;
                }
                else if (working == "Chest")
                {
                    chestCount++;
                    workout++;
                }
                else if (working == "Legs")
                {
                    legsCount++;
                    workout++;
                }
                else if (working == "Abs")
                {
                    absCount++;
                    workout++;
                }
                else if (working == "Protein shake")
                {
                    proteinShakeCount++;
                    buying++;
                }
                else if (working == "Protein bar")
                {
                    proteinBarCount++;
                    buying++;
                }
            }
            Console.WriteLine($"{backCount} - back");
            Console.WriteLine($"{chestCount} - chest");
            Console.WriteLine($"{legsCount} - legs");
            Console.WriteLine($"{absCount} - abs");
            Console.WriteLine($"{proteinShakeCount} - protein shake");
            Console.WriteLine($"{proteinBarCount} - protein bar");
            Console.WriteLine($"{(workout / visitorsCount * 1.00) * 100:f2}% - work out");
            Console.WriteLine($"{(buying / visitorsCount * 1.00) * 100:f2}% - protein");
        }
    }
}
