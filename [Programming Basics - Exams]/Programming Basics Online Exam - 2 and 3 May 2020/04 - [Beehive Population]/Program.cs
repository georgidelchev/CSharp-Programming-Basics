using System;

namespace BeehivePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPopulation = int.Parse(Console.ReadLine());
            int yearsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= yearsCount; i++)
            {
                int newBees = startingPopulation / 10 * 2;
                startingPopulation += newBees;
                if (i % 5 == 0)
                {
                    int migratedBees = startingPopulation / 50 * 5;
                    startingPopulation -= migratedBees;
                }
                int deadBees = startingPopulation / 20 * 2;
                startingPopulation -= deadBees;
            }
            Console.WriteLine($"Beehive population: {startingPopulation}");
        }
    }
}
