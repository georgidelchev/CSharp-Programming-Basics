using System;

namespace HoneyWinterReserves
{
    class Program
    {
        static void Main(string[] args)
        {
            double honeyForTheWinter = double.Parse(Console.ReadLine());
            double honeyHarvested = 0;

            string beeName = Console.ReadLine();
            while (beeName != "Winter has come")
            {
                double currHoney = 0;
                for (int i = 1; i <= 6; i++)
                {
                    double honey = double.Parse(Console.ReadLine());

                    currHoney += honey;
                }
                if (currHoney < 0)
                {
                    Console.WriteLine($"{beeName} was banished for gluttony");
                }
                honeyHarvested += currHoney;
                if (honeyHarvested >= honeyForTheWinter)
                {
                    double honeyLeft = honeyHarvested - honeyForTheWinter;
                    Console.WriteLine($"Well done! Honey surplus {honeyLeft:f2}.");
                    break;
                }
                beeName = Console.ReadLine();
            }

            if (beeName == "Winter has come")
            {
                if (honeyHarvested < honeyForTheWinter)
                {
                    double honeyNeeded = honeyForTheWinter - honeyHarvested;
                    Console.WriteLine($"Hard Winter! Honey needed {honeyNeeded:f2}.");
                }
            }
        }
    }
}
