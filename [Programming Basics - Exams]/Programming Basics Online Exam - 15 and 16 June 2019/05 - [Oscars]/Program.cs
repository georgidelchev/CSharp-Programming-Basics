using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int judgesNumber = int.Parse(Console.ReadLine());

            double totalPoints = startingPoints;

            for (int i = 0; i < judgesNumber; i++)
            {
                string judgeName = Console.ReadLine();
                double pointsGiven = double.Parse(Console.ReadLine());
                double pts = (judgeName.Length * pointsGiven) / 2;
                totalPoints += pts;
                if (totalPoints >= 1250.50)
                {
                    Console.WriteLine($"Congratulations, {name} got a " +
                        $"nominee for leading role with {totalPoints:f1}!");
                    break;
                }
            }
            if (totalPoints < 1250.50)
            {
                Console.WriteLine($"Sorry, {name} you need {1250.50 - totalPoints:f1} more! ");
            }
        }
    }
}
